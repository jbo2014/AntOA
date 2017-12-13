using System;
using System.Collections.Generic;

namespace Ant.Entity.DB
{   
    /// <summary>
    /// 实体-SysRole 
    /// </summary>  
	[Table("SysRole")]
	public class Role
    {    
        public Guid RoleGuid { get; set; }
          public String RoleName { get; set; }
    } 
}
