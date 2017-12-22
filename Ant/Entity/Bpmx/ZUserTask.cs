using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Ant.Enact;
using Ant.Enact.Activity;

namespace Ant.Entity.Bpmx
{
    [XmlRoot("UserTask")]
    internal class ZUserTask:ZElement
    {
        public Exchange Exchange
        {
            get
            {
                return new UserTask();
            }
            set
            {
                this.Exchange = value;
            }
        }

        [XmlAttribute("ID")]
        public string ID { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlElement("TaskTitle")]
        public string TaskTitle { get; set; }

        [XmlElement("TaskPage")]
        public string TaskPage { get; set; }
    }
}
