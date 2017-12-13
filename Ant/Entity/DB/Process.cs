using System;
using System.Collections.Generic;

namespace Ant.Entity.DB
{   
    /// <summary>
    /// 实体-WfProcess 
    /// </summary>  
	[Table("WfProcess")]
	public class Process
    {    
        public Guid ProcessGuid { get; set; }
          public String ProcessName { get; set; }
          public Boolean? IsMaster { get; set; }
          public Byte ProcessStatus { get; set; }
          public String Description { get; set; }
          public DateTime CreateTime { get; set; }
          public DateTime? UpdateTime { get; set; }
          public Byte[] Stamp { get; set; }
          public String Version { get; set; }
          public String BpmFile { get; set; }
          public String BpmPath { get; set; }
          public String BpmContent { get; set; }
          public Guid? DepotGuid { get; set; }
          public String DepotName { get; set; }
    } 
}
