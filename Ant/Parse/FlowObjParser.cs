using System;
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
                        if (reader.Name.ToUpper() == "SEQUENCE")
                        {
                            if (reader.GetAttribute("ID") == sequenceID)
                            {
                                while (reader.Read())
                                {
                                    if (reader.Name.ToUpper() == "TARGET")
                                    {
                                        nextStepID = reader.ReadElementContentAsString();
                                        break;
                                    }
                                }
                            }
                            reader.Skip();
                        }
                        else if (reader.Name.ToUpper() == "STEP")
                        {
                            if(reader.GetAttribute("ID") == nextStepID){
                                while (reader.Read())
                                {
                                    if(reader.Name.ToUpper() == "BLOCK")
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
            string rightLine = string.Empty;
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
                        if (reader.Name.ToUpper() == "SEQUENCE")
                        {
                            if (reader.GetAttribute("Source") == stepID)
                            {
                                rightLine = reader.GetAttribute("Target");
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
                        if (reader.Name.ToUpper() == "SEQUENCE")
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
                    if (reader.MoveToContent() == XmlNodeType.Element && reader.Name.ToUpper() == "STARTEVENT")
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
        #endregion
    }
}
