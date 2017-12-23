using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Ant.Enact;

namespace Ant.Entity.Bpmx
{
    [XmlRoot("Sequence")]
    public class ZSequence : ZElement
    {
        [XmlIgnore]
        public Exchange Exchange
        {
            get
            {
                return new Sequence();
            }
            set
            {
                this.Exchange = value;
            }
        }

        [XmlAttribute("ID")]
        public string ID { get; set; }

        /// <summary>
        /// 连线上的标题
        /// </summary>
        [XmlAttribute("Name")]
        public string Name { get; set; }

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
