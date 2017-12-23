using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ant.Entity.Bpmx
{
    [XmlRoot("Atomies")]
    public class ZBlock
    {
        [XmlElement("ID")]
        public string ID { get; set; }

        [XmlElement("Title")]
        public string Title { get; set; }
    }
}
