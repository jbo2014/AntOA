using System;
using System.Collections.Generic;

namespace Ant.Entity.DB
{   
    /// <summary>
    /// 实体-WfSerialNum 
    /// </summary>  
	[Table("WfSerialNum")]
	public class SerialNum
    {    
        public Guid SerialGuid { get; set; }
          public String SerialName { get; set; }
          public String CurrentNum { get; set; }
          public Int32 Step { get; set; }
          public String Filler { get; set; }
          public DateTime CreateTime { get; set; }
          public DateTime? UpdateTime { get; set; }
    } 
}
