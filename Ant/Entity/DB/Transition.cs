using System;
using System.Collections.Generic;

namespace Ant.Entity.DB
{   
    /// <summary>
    /// 实体-WfTransition 
    /// </summary>  
	[Table("WfTransition")]
	public class Transition
    {    
        public Guid TransferGuid { get; set; }
          public Guid InstanceGuid { get; set; }
          public Byte TransferType { get; set; }
          public String ConditionResult { get; set; }
          public Guid SourceGuid { get; set; }
          public Guid TargetGuid { get; set; }
          public Byte[] Stamp { get; set; }
    } 
}
