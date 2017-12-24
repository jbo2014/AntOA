using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Ant.Enact;
using Ant.Enact.Gateway;

namespace Ant.Entity.Bpmx
{
    /// <summary>
    /// 排他网关
    /// </summary>
    class ZExclusiveGateway : ZElement
    {
        [XmlIgnore]
        public Exchange Exchange
        {
            get
            {
                return new ExclusiveGateway();
            }
            set
            {
                this.Exchange = value;
            }
        }

        /// <summary>
        /// ID
        /// </summary>
        [XmlAttribute("ID")]
        public string ID { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [XmlAttribute("Name")]
        public string Name { get; set; }
    }
}
