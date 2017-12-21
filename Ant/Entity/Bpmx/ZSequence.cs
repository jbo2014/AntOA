using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ant.Entity.Bpmx
{
    [XmlRoot("Sequence")]
    public class ZSequence
    {
        [XmlElement("ID")]
        public string ID { get; set; }

        /// <summary>
        /// 连线上的标题
        /// </summary>
        [XmlElement("Title", IsNullable = true)]
        public string Title { get; set; }

        /// <summary>
        /// 连接线的起始节点
        /// </summary>
        [XmlElement("Source")]
        public string Source { get; set; }

        /// <summary>
        /// 连接线的目标节点
        /// </summary>
        [XmlElement("Target")]
        public string Target { get; set; }

        /// <summary>
        /// 连接线上的表达式
        /// </summary>
        [XmlElement("Express", IsNullable = true)]
        public string Express { get; set; }
    }
}
