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
    public partial class SysDeptUser
    {
        public SysDeptUser()
        {
            
        }

        		[Key]		public Guid DeptUserGuid { get; set; }		[DisplayName("部门Guid")]		public Guid DeptGuid { get; set; }		[DisplayName("用户Guid")]		public Guid UserGuid { get; set; } 
        
        
    }
}