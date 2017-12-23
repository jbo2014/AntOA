using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ant.Entity.Bpmx
{
    [XmlRoot("Flow")]
    public class ZFlow
    {
        [XmlArray("Sequences"), XmlArrayItem("Sequence")]
        public List<ZSequence> Sequences { get; set; }

        [XmlArray("Steps"), XmlArrayItem("Step")]
        public List<ZStep> Steps { get; set; }
    }
}
