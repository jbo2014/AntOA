using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ant.Entity.Bpmx
{
    [XmlRoot("Process")]
    public class ZProcess
    {
        [XmlElement("ProcessID")]
        public Guid ProcessID { get; set; }

        [XmlElement("Title")]
        public string Title { get; set; }

        [XmlElement("Author")]
        public string Author { get; set; }

        [XmlElement("CodeType")]
        public string CodeType { get; set; }

        [XmlElement("Version")]
        public string Version { get; set; }

        [XmlElement("Created")]
        public DateTime Created { get; set; }

        [XmlElement("Release")]
        public bool Release { get; set; }

        [XmlElement("Flows")]
        public ZFlow Flows { get; set; }

        [XmlElement("Blocks")]
        public ZBlock Blocks { get; set; }

        [XmlArrayAttribute("Pages"), XmlArrayItem("Page")]
        public List<ZPage> Pages { get; set; }

        [XmlArray("Params"), XmlArrayItem("Param")]
        public List<ZParam> Params { get; set; }
    }
}
