using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    /// <summary>
    /// 文件说明: 信息实体
    /// 作    者: 王俊波
    /// 生成日期: 2017-12-14
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class SysDepartment
    {
        public SysDepartment()
        {
            			this.SysDeptUser_DeptGuidList = new List<SysDeptUser>();
        }

        		[Key]		public Guid DeptGuid { get; set; }		[DisplayName("部门名称")]		public string DeptName { get; set; }		[DisplayName("上级部门Guid")]		public Guid HiDeptGuid { get; set; }		[DisplayName("部门负责人")]		public Nullable<Guid> DeptLeader { get; set; } 
        
        		public virtual ICollection<SysDeptUser> SysDeptUser_DeptGuidList { get; set; }
    }
}