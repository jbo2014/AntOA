using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ant.Entity.Xpdl
{
    [XmlRoot("Param")]
    public class ZParam
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlRoot("Type")]
        public string Type { get; set; }

        [XmlRoot("IsArray")]
        public bool IsArray { get; set; }

        /// <summary>
        /// 参数组的名字
        /// </summary>
        [XmlRoot("GroupName", IsNullable = true)]
        public string GroupName { get; set; }

        [XmlRoot("Value", IsNullable = true)]
        public string Value { get; set; }
    }
}
