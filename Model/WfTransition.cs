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
    public partial class WfTransition
    {
        public WfTransition()
        {
            
        }

        		[Key]		public Guid TransferGuid { get; set; }		[DisplayName("流程实例Guid")]		public Guid InstanceGuid { get; set; }		[DisplayName("转交类型")]		public byte TransferType { get; set; }		[DisplayName("条件解析结果")]		public Nullable<string> ConditionResult { get; set; }		[DisplayName("原节点Guid")]		public Guid SourceGuid { get; set; }		[DisplayName("目标节点Guid")]		public Guid TargetGuid { get; set; }		[DisplayName("时间戳")]		public Nullable<byte[]> Stamp { get; set; } 
        
        
    }
}