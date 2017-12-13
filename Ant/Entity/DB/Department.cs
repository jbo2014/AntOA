using System;
using System.Collections.Generic;

namespace Ant.Entity.DB
{   
    /// <summary>
    /// 实体-SysDepartment 
    /// </summary>  
	[Table("SysDepartment")]
	public class Department
    {    
        public Guid DeptGuid { get; set; }
          public String DeptName { get; set; }
          public Guid HiDeptGuid { get; set; }
          public Guid? DeptLeader { get; set; }
    } 
}
