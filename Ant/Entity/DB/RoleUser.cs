using System;
using System.Collections.Generic;

namespace Ant.Entity.DB
{   
    /// <summary>
    /// 实体-SysRoleUser 
    /// </summary>  
	[Table("SysRoleUser")]
	public class RoleUser
    {    
        public Guid RoleUserGuid { get; set; }
          public Guid RoleGuid { get; set; }
          public Guid UserGuid { get; set; }
    } 
}
