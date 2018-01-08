using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    /// <summary>
    /// 文件说明: 信息实体
    /// 作    者: JBO
    /// 生成日期: 2017年12月30日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class SysRoleUser
    {
        [Key]
        public Guid RoleUserGuid { get; set; }
 
        [DisplayName("角色Guid")]
        public Guid RoleGuid { get; set; }
 
        [DisplayName("用户Guid")]
        public Guid UserGuid { get; set; }
 
        public virtual SysRole RoleGuid_FK { get; set; }
        public virtual SysUser UserGuid_FK { get; set; }
    }
}
