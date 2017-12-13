using System;
using System.Collections.Generic;

namespace Ant.Entity.DB
{   
    /// <summary>
    /// 实体-WfTask 
    /// </summary>  
	[Table("WfTask")]
	public class Task
    {    
        public Guid TaskGuid { get; set; }
          public Guid InstanceGuid { get; set; }
          public Guid NodeGuid { get; set; }
          public String TaskTitle { get; set; }
          public Byte? TaskType { get; set; }
          public Byte TaskStatus { get; set; }
          public Guid TaskOwner { get; set; }
          public Guid TaskActor { get; set; }
          public Byte[] Stamp { get; set; }
    } 
}
