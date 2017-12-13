using System;
using System.Collections.Generic;

namespace Ant.Entity.DB
{   
    /// <summary>
    /// 实体-WfNode 
    /// </summary>  
	[Table("WfNode")]
	public class Node
    {    
        public Guid NodeGuid { get; set; }
          public Guid InstanceGuid { get; set; }
          public String StepDefID { get; set; }
          public Byte NodeType { get; set; }
          public Guid? RawNodeGuid { get; set; }
          public Guid? Sponsor { get; set; }
          public Double? PassRate { get; set; }
          public Byte? AddSign { get; set; }
          public DateTime StartTime { get; set; }
          public DateTime? EndTime { get; set; }
    } 
}
