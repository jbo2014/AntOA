using System;
using System.Collections.Generic;

namespace Ant.Entity.DB
{   
    /// <summary>
    /// 实体-WfInstance 
    /// </summary>  
	[Table("WfInstance")]
	public class Instance
    {    
        public Guid InstanceGuid { get; set; }
          public Guid ProcessGuid { get; set; }
          public String ProcessVersion { get; set; }
          public String InstanceTitle { get; set; }
          public Byte InstanceStatus { get; set; }
          public Guid? CurrentTask { get; set; }
          public Guid Originator { get; set; }
          public DateTime StartTime { get; set; }
          public Guid? Terminator { get; set; }
          public DateTime? EndTime { get; set; }
          public Byte[] Stamp { get; set; }
    } 
}
