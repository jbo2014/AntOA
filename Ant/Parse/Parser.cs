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
    internal class Parser
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
        public object FindRightNode(Stream processXml, string sequenceID) 
        {
            string nextObjStr = string.Empty;       // 下一步Block字符串
            string nextStepID = string.Empty;       // 下一步节点ID
            string nextBlockID = string.Empty;      // 下一步BlockID
            string nextBlockType = null;
            bool skip = false;
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

            return XmlUtil.Deserialize(Type.GetType(nextBlockType), nextObjStr);
        }

        /// <summary>
        /// 获取流程定义中的所有开始节点
        /// </summary>
        /// <param name="processXml"></param>
        /// <returns></returns>
        public List<ZStartEvent> FindStartNode(Stream processXml)
        {
            StringBuilder startObjs = new StringBuilder();
            using (XmlReader reader = XmlReader.Create(processXml))
            {
                reader.ReadToFollowing("Blocks");
                while (reader.Read())
                {
                    if (reader.MoveToContent() == XmlNodeType.Element && reader.Name.ToUpper() == "STARTEVENT")
                    {
                        startObjs.Append(reader.ReadOuterXml());
                        break;
                    }
                    reader.Skip();
                }
            }
            return XmlUtil.Deserialize(typeof(List<ZStartEvent>), startObjs.ToString()) as List<ZStartEvent>;
        }
        #endregion
    }
}
