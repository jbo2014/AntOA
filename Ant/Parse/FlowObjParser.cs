﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using Ant.Enact;
using Ant.Utility;
using Ant.Entity.Bpmx;


namespace Ant.Parse
{
    public class FlowObjParser
    {
        private XElement xmlDoc;

        #region 加载xml
        public void LoadProcessByFile(string filePath)
        {
            this.xmlDoc = XElement.Load(filePath);
        }

        public void LoadProcessByString(string xmlString)
        {
            this.xmlDoc = XElement.Parse(xmlString);
        }

        public void LoadProcessByStream(Stream xmlStream)
        {
            this.xmlDoc = XElement.Load(xmlStream);
        }
        #endregion

        #region 寻找节点
        /// <summary>
        /// 在流程定义图中，连线的Target节点
        /// </summary>
        /// <param name="processXml"></param>
        /// <param name="sequenceID">连接线的ID</param>
        /// <returns></returns>
        public object FindRightNode1(Stream processXml, string sequenceID) 
        {
            string nextObjStr = string.Empty;       // 下一步Block字符串
            string nextStepID = string.Empty;       // 下一步节点ID
            string nextBlockID = string.Empty;      // 下一步BlockID
            string nextBlockType = null;
            bool skip = false;
            StreamUtil.Restore(ref processXml);
            using (XmlReader reader = XmlReader.Create(processXml)) 
            {
                reader.ReadToFollowing("Flows");
                while (reader.Read() && !skip) 
                {                    
                    if (reader.MoveToContent() == XmlNodeType.Element)
                    {
                        if (String.Equals(reader.Name,"SEQUENCE",StringComparison.CurrentCultureIgnoreCase))
                        {
                            if (reader.GetAttribute("ID") == sequenceID)
                            {
                                while (reader.Read())
                                {
                                    if (String.Equals(reader.Name,"TARGET",StringComparison.CurrentCultureIgnoreCase))
                                    {
                                        nextStepID = reader.ReadElementContentAsString();
                                        break;
                                    }
                                }
                            }
                            reader.Skip();
                        }
                        else if (String.Equals(reader.Name,"STEP",StringComparison.CurrentCultureIgnoreCase))
                        {
                            if(reader.GetAttribute("ID") == nextStepID){
                                while (reader.Read())
                                {
                                    if(String.Equals(reader.Name,"Block",StringComparison.CurrentCultureIgnoreCase))
                                    {
                                        nextBlockID = reader.ReadElementContentAsString();
                                        skip = true;
                                        break;
                                    }
                                }
                            }
                            reader.Skip();
                        }
                    }
                }

                reader.ReadToFollowing("Blocks");
                while(reader.Read())
                {
                    if (reader.MoveToContent() == XmlNodeType.Element && reader.GetAttribute("ID") == nextBlockID)
                    {
                        nextBlockType = reader.Name;
                        nextObjStr = reader.ReadOuterXml();
                        break;
                    }
                    reader.Skip();
                }
            }

            return XmlUtil.Deserialize(Type.GetType("Ant.Entity.Bpmx.Z" + nextBlockType), nextObjStr);
        }

        public object FindRight(Stream processXml, bool findLine, string id) 
        {
            object right = new object();
            if (findLine)
                right = FindRightLines(processXml, id);
            else
                right = FindRightNode(processXml, id);
            return right;
        }

        /// <summary>
        /// 在流程定义图中，节点的后续连线
        /// </summary>
        /// <param name="processXml"></param>
        /// <param name="sequenceID">连接线的ID</param>
        /// <returns></returns>
        public List<ZSequence> FindRightLines(Stream processXml, string stepID)
        {
            List<ZSequence> lines = new List<ZSequence>();
            bool skip = false;
            StreamUtil.Restore(ref processXml);
            using (XmlReader reader = XmlReader.Create(processXml))
            {
                reader.ReadToFollowing("Sequences");
                while (reader.Read() && !skip)
                {
                    if (reader.MoveToContent() == XmlNodeType.Element)
                    {
                        if (String.Equals(reader.Name,"SEQUENCE",StringComparison.CurrentCultureIgnoreCase))
                        {
                            if (reader.GetAttribute("Source") == stepID)
                            {
                                lines.Add(XmlUtil.Deserialize<ZSequence>(reader.ReadOuterXml()));
                            }
                        }
                        else
                            break;
                    }
                }
            }

            return lines;
        }

        /// <summary>
        /// 在流程定义图中，获取节点的 输入 或 输出 连线
        /// </summary>
        /// <param name="processXml"></param>
        /// <param name="sequenceID">连接线的ID</param>
        /// <param name="side">想要获取流出连线： false进入连线，true流出连线</param>
        /// <returns></returns>
        public List<ZSequence> FindOneSideLines(Stream processXml, string stepID, bool side)
        {
            string rightLine = string.Empty;
            List<ZSequence> lines = new List<ZSequence>();
            bool skip = false;
            StreamUtil.Restore(ref processXml);
            string known = string.Empty;    
            if (side)
                known = "Source";
            else
                known = "Target";

            using (XmlReader reader = XmlReader.Create(processXml))
            {
                reader.ReadToFollowing("Sequences");
                while (reader.Read() && !skip)
                {
                    if (reader.MoveToContent() == XmlNodeType.Element)
                    {
                        if (String.Equals(reader.Name,"SEQUENCE",StringComparison.CurrentCultureIgnoreCase))
                        {
                            if (reader.GetAttribute(known) == stepID)
                            {
                                lines.Add(XmlUtil.Deserialize<ZSequence>(reader.ReadOuterXml()));
                            }
                        }
                        else
                            break;
                    }
                }
            }

            return lines;
        }

        /// <summary>
        /// 在流程定义图中，获取节点的 输入 和 输出 连线
        /// </summary>
        /// <param name="processXml"></param>
        /// <param name="sequenceID">连接线的ID</param>
        /// <param name="side">想要获取流出连线： false进入连线，true流出连线</param>
        /// <returns></returns>
        public List<ZSequence> FindAllSidesLines(Stream processXml, string stepID)
        {
            string rightLine = string.Empty;
            List<ZSequence> lines = new List<ZSequence>();
            bool skip = false;
            StreamUtil.Restore(ref processXml);
            string known = string.Empty;
            using (XmlReader reader = XmlReader.Create(processXml))
            {
                reader.ReadToFollowing("Sequences");
                while (reader.Read() && !skip)
                {
                    if (reader.MoveToContent() == XmlNodeType.Element)
                    {
                        if (String.Equals(reader.Name,"SEQUENCE",StringComparison.CurrentCultureIgnoreCase))
                        {
                            if (reader.GetAttribute("Source") == stepID || reader.GetAttribute("Target") == stepID)
                            {
                                lines.Add(XmlUtil.Deserialize<ZSequence>(reader.ReadOuterXml()));
                            }
                        }
                        else
                            break;
                    }
                }
            }

            return lines;
        }

        /// <summary>
        /// 在流程定义图中，连线的Target节点
        /// </summary>
        /// <param name="processXml"></param>
        /// <param name="sequenceID">连接线的ID</param>
        /// <returns></returns>
        public object FindRightNode(Stream processXml, string sequenceID)
        {
            string nextObjStr = string.Empty;       // 下一步Block字符串
            string nextStepID = string.Empty;       // 下一步节点ID
            string nextBlockType = null;
            bool skip = false;
            StreamUtil.Restore(ref processXml);
            using (XmlReader reader = XmlReader.Create(processXml))
            {
                reader.ReadToFollowing("Sequences");
                while (reader.Read() && !skip)
                {
                    if (reader.MoveToContent() == XmlNodeType.Element)
                    {
                        if (String.Equals(reader.Name,"SEQUENCE",StringComparison.CurrentCultureIgnoreCase))
                        {
                            if (reader.GetAttribute("ID") == sequenceID)
                            {
                                nextStepID = reader.GetAttribute("Target");
                                break;
                            }
                        }
                    }
                }

                reader.ReadToFollowing("Steps");
                while (reader.Read())
                {
                    if (reader.MoveToContent() == XmlNodeType.Element && reader.GetAttribute("ID") == nextStepID)
                    {
                        nextBlockType = reader.Name;
                        nextObjStr = reader.ReadOuterXml();
                        break;
                    }
                    reader.Skip();
                }
            }

            Type type = Type.GetType("Ant.Entity.Bpmx.Z" + nextBlockType);
            return XmlUtil.Deserialize(type, nextObjStr);
        }

        /// <summary>
        /// 获取流程定义中的所有开始节点
        /// </summary>
        /// <param name="processXml"></param>
        /// <returns></returns>
        public List<ZStartEvent> FindStartNode(Stream processXml)
        {
            List<ZStartEvent> starters = new List<ZStartEvent>();
            StreamUtil.Restore(ref processXml);
            using (XmlReader reader = XmlReader.Create(processXml))
            {
                reader.ReadToFollowing("Steps");
                while (reader.Read())
                {
                    if (reader.MoveToContent() == XmlNodeType.Element && String.Equals(reader.Name,"STARTEVENT",StringComparison.CurrentCultureIgnoreCase))
                    {
                        starters.Add(XmlUtil.Deserialize(typeof(ZStartEvent), reader.ReadOuterXml()) as ZStartEvent);
                    }
                    else
                    {
                        reader.Skip();
                    }
                }
            }
            return starters;
        }

        public List<ZParam> FindAllParams(Stream processXml) 
        {
            List<ZParam> paramList = new List<ZParam>();
            StreamUtil.Restore(ref processXml);
            using (XmlReader reader = XmlReader.Create(processXml))
            {
                reader.ReadToFollowing("Params");
                while (reader.Read())
                {
                    if (reader.MoveToContent() == XmlNodeType.Element)
                    {
                        if (String.Equals(reader.Name,"PARAM",StringComparison.CurrentCultureIgnoreCase))
                        {
                            paramList.Add(XmlUtil.Deserialize(typeof(ZParam), reader.ReadOuterXml()) as ZParam);
                        }
                    }
                }
            }
            return paramList;
        }

        /// <summary>
        /// 寻找节点
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="processXml"></typeparam>
        /// <param name="tag">节点Tag名称</param>
        /// <param name="id">节点ID</param>
        /// <returns></returns>
        public T FindNode<T>(Stream processXml, string tag, string id)
        {
            object o = null;
            using (XmlReader reader = XmlReader.Create(processXml))
            {
                do
                {
                    reader.ReadToFollowing(tag);
                    if (reader.MoveToContent() == XmlNodeType.Element)
                    {
                        if (String.Equals(reader.Name, tag, StringComparison.CurrentCultureIgnoreCase) && String.Equals(reader.GetAttribute("ID"), id, StringComparison.CurrentCultureIgnoreCase))
                        {
                            o = XmlUtil.Deserialize<T>(reader.ReadOuterXml());
                        }
                    }
                } while (reader.Read());
            }
            return (T)o;
        }
        #endregion

        #region 寻找节点List
        public List<T> GetElementList<T>(Stream processXml, string xmlTag)
        {
            List<T> elements = new List<T>();
            bool skip = false;
            StreamUtil.Restore(ref processXml);
            using (XmlReader reader = XmlReader.Create(processXml))
            {
                reader.ReadToFollowing(xmlTag + "s");
                while (reader.Read() && !skip)
                {
                    if (reader.MoveToContent() == XmlNodeType.Element)
                    {
                        if (String.Equals(reader.Name,xmlTag,StringComparison.CurrentCultureIgnoreCase))
                        {
                            elements.Add(XmlUtil.Deserialize<T>(reader.ReadOuterXml()));
                        }
                        else
                            break;
                    }
                }
            }
            return elements;
        }
        #endregion
    }
}
