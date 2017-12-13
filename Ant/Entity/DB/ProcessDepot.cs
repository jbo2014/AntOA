using System;
using System.Collections.Generic;

namespace Ant.Entity.DB
{   
    /// <summary>
    /// 实体-WfProcessDepot 
    /// </summary>  
	[Table("WfProcessDepot")]
	public class ProcessDepot
    {    
        public Guid DepotGuid { get; set; }
          public Guid ProcessGuid { get; set; }
          public String Version { get; set; }
          public String XmlFile { get; set; }
          public String XmlPath { get; set; }
          public String XmlContent { get; set; }
          public DateTime CreateTime { get; set; }
          public DateTime? UpdateTime { get; set; }
          public Byte[] Stamp { get; set; }
    } 
}
