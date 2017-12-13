using System;
using System.Collections.Generic;

namespace Ant.Entity.DB
{   
    /// <summary>
    /// 实体-SysUser 
    /// </summary>  
	[Table("SysUser")]
	public class User
    {    
        public Guid UserGuid { get; set; }
          public String UserID { get; set; }
          public String UserPwd { get; set; }
          public String UserName { get; set; }
          public Boolean? UserSex { get; set; }
          public String Phone { get; set; }
          public String Email { get; set; }
    } 
}
