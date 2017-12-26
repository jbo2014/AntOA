using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    /// <summary>
    /// 文件说明: 信息实体
    /// 作    者: WJB
    /// 生成日期: 2017年12月26日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class WfNode
    {
        [Key]
        public Guid NodeGuid { get; set; }
 
        [DisplayName("流程实例Guid")]
        public Guid InstanceGuid { get; set; }
 
        [DisplayName("流程定义中节点ID")]
        public string StepDefID { get; set; }
 
        [DisplayName("节点类型")]
        public byte NodeType { get; set; }
 
        [DisplayName("退回前原始节点Guid")]
        public Nullable<Guid> RawNodeGuid { get; set; }
 
        [DisplayName("多实例下主办人ID")]
        public Nullable<Guid> Sponsor { get; set; }
 
        [DisplayName("通过率")]
        public Nullable<double> PassRate { get; set; }
 
        [DisplayName("加签类型")]
        public Nullable<byte> AddSign { get; set; }
 
        [DisplayName("开始时间")]
        public DateTime StartTime { get; set; }
 
        [DisplayName("结束时间")]
        public Nullable<DateTime> EndTime { get; set; }
 
        public virtual WfInstance InstanceGuid_FK { get; set; }
    }
}
