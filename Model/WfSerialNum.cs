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
    public partial class WfSerialNum
    {
        public WfSerialNum()
        {
            
        }

        		[Key]		public Guid SerialGuid { get; set; }		[DisplayName("序号名称")]		public string SerialName { get; set; }		[DisplayName("当前序号")]		public string CurrentNum { get; set; }		[DisplayName("步长")]		public int Step { get; set; }		[DisplayName("填充字符")]		public Nullable<string> Filler { get; set; }		[DisplayName("创建时间")]		public DateTime CreateTime { get; set; }		[DisplayName("更新时间")]		public Nullable<DateTime> UpdateTime { get; set; } 
        
        
    }
}