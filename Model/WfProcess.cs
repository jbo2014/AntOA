using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    /// <summary>
    /// 文件说明: 流程定义表信息实体
    /// 作    者: 王俊波
    /// 生成日期: 2017-12-14
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class WfProcess
    {
        public WfProcess()
        {
            
        }

        		[Key]		public Guid ProcessGuid { get; set; }		[DisplayName("流程定义名称")]		public Nullable<string> ProcessName { get; set; }		[DisplayName("主版本（当前时间新建流程时使用的流程版本）")]		public Nullable<string> MasterVer { get; set; }		[DisplayName("创建时间")]		public DateTime CreateTime { get; set; }		[DisplayName("最新更新时间")]		public Nullable<DateTime> UpdateTime { get; set; }		[DisplayName("时间戳")]		public Nullable<byte[]> Stamp { get; set; }		[DisplayName("状态：0未发布；1已发布；2重构中；3测试中")]		public Nullable<byte> Status { get; set; } 
        
        
    }
}