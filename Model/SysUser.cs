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
    public partial class SysUser
    {
        public SysUser()
        {
            			this.SysDeptUser_UserGuidList = new List<SysDeptUser>();			this.SysRoleUser_UserGuidList = new List<SysRoleUser>();
        }

        		[Key]		public Guid UserGuid { get; set; }		[DisplayName("登录帐号")]		public string UserID { get; set; }		[DisplayName("登录密码")]		public string UserPwd { get; set; }		[DisplayName("用户姓名")]		public string UserName { get; set; }		[DisplayName("性别")]		public Nullable<bool> UserSex { get; set; }		[DisplayName("手机")]		public Nullable<string> Phone { get; set; }		[DisplayName("邮箱")]		public Nullable<string> Email { get; set; } 
        
        		public virtual ICollection<SysDeptUser> SysDeptUser_UserGuidList { get; set; }		public virtual ICollection<SysRoleUser> SysRoleUser_UserGuidList { get; set; }
    }
}