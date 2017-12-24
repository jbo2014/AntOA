using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Ant.Enact;
using Ant.Enact.Event;

namespace Ant.Entity.Bpmx
{
    [XmlRoot("EndEvent")]
    public class ZEndEvent : ZElement
    {
        [XmlIgnore]
        public Exchange Exchange 
        {
            get 
            {
                return new EndEvent();
            }
            set 
            {
                this.Exchange = value;
            }
        }

        /// <summary>
        /// 开始事件ID
        /// </summary>
        [XmlAttribute("ID")]
        public string ID { get; set; }

        /// <summary>
        /// 开始事件类型
        /// </summary>
        [XmlElement("Type")]
        public string Type { get; set; }

        /// <summary>
        /// 事件定义
        /// </summary>
        [XmlElement("Define")]
        public string Define { get; set; }
    }
}
