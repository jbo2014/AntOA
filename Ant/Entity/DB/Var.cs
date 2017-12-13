using System;
using System.Collections.Generic;

namespace Ant.Entity.DB
{   
    /// <summary>
    /// 实体-WfVar 
    /// </summary>  
	[Table("WfVar")]
	public class Var
    {    
        public Guid ParamGuid { get; set; }
          public Guid InstanceGuid { get; set; }
          public String ParamName { get; set; }
          public String Value { get; set; }
    } 
}
