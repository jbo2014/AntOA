using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ant.Entity.Bpmx
{
    [XmlRoot("Param")]
    internal class ZParam
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Type")]
        public string Type { get; set; }

        [XmlElement("IsArray")]
        public bool IsArray { get; set; }

        /// <summary>
        /// 参数组的名字
        /// </summary>
        [XmlElement("GroupName", IsNullable = true)]
        public string GroupName { get; set; }

        [XmlElement("Value", IsNullable = true)]
        public string Value { get; set; }
    }
}
