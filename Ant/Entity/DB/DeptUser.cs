using System;
using System.Collections.Generic;

namespace Ant.Entity.DB
{   
    /// <summary>
    /// 实体-SysDeptUser 
    /// </summary>  
	[Table("SysDeptUser")]
	public class DeptUser
    {    
        public Guid DeptUserGuid { get; set; }
          public Guid DeptGuid { get; set; }
          public Guid UserGuid { get; set; }
    } 
}
