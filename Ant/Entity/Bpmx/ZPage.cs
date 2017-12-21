using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ant.Entity.Bpmx
{
    [XmlRoot("Page")]
    public class ZPage
    {
        [XmlElement("Page")]
        public string ID { get; set; }

        [XmlElement("Title")]
        public string Title { get; set; }

        [XmlElement("Type")]
        public string Type { get; set; }

        [XmlElement("Url")]
        public string Url { get; set; }

        [XmlElement("Fields")]
        public string Fields { get; set; }

        [XmlElement("Content")]
        public string Content { get; set; }

        [XmlElement("OnCreate")]
        public string OnCreate { get; set; }

        [XmlElement("OnSubmit")]
        public string OnSubmit { get; set; }

        [XmlElement("Methods")]
        public string Methods { get; set; }
    }
}
