using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ant.Entity.Bpmx
{
    [XmlRoot("Step")]
    public class ZStep
    {
        [XmlElement("ID")]
        public string ID { get; set; }

        [XmlElement("Title")]
        public string Title { get; set; }

        [XmlElement("Type")]
        public string Type { get; set; }

        /// <summary>
        /// Elements中的某个Element的ID
        /// </summary>
        [XmlElement("Element", IsNullable = true)]
        public string Element { get; set; }
    }
}
