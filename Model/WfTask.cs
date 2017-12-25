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
    /// 生成日期: 2017年12月18日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class WfTask
    {
        [Key]
        public Guid TaskGuid { get; set; }
 
        [DisplayName("流程实例Guid")]
        public Guid InstanceGuid { get; set; }
 
        [DisplayName("流程实例的节点GUID")]
        public Guid NodeGuID { get; set; }

        [DisplayName("流程定义的节点ID")]
        public string NodeID { get; set; }
 
        [DisplayName("任务标题")]
        public string TaskTitle { get; set; }
 
        [DisplayName("任务类型：   0.正常处理   1.加签者   2.受托者")]
        public Nullable<byte> TaskType { get; set; }
 
        [DisplayName("任务状态： 0.未认领 1.已认领 2.挂起 3.完成")]
        public byte TaskStatus { get; set; }
 
        [DisplayName("任务所有者的用户ID")]
        public Guid Owner { get; set; }
 
        [DisplayName("实际执行者的用户ID")]
        public Guid Executor { get; set; }
 
        public virtual WfInstance InstanceGuid_FK { get; set; }
        public virtual WfNode NodeGuid_FK { get; set; }
    }
}
