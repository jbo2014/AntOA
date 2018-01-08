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
    public partial class RtTransition
    {
        [Key]
        public Guid TransferGuid { get; set; }
 
        [DisplayName("流程实例Guid")]
        public Guid InstanceGuid { get; set; }
 
        //[DisplayName("转交类型")]
        //public byte TransferType { get; set; }

        [DisplayName("条件")]
        public string Condition { get; set; }
 
        [DisplayName("条件解析结果")]
        public string ConditionResult { get; set; }
 
        [DisplayName("原节点Guid")]
        public Guid SourceGuid { get; set; }
 
        [DisplayName("目标节点Guid")]
        public Guid TargetGuid { get; set; }
 
        public virtual RtInstance InstanceGuid_FK { get; set; }
    }
}
