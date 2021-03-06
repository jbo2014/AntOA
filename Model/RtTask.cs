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
    public partial class RtTask
    {
        [Key]
        public Guid TaskGuid { get; set; }
 
        [DisplayName("流程实例Guid")]
        public Guid InstanceGuid { get; set; }

        [DisplayName("活动实例Guid")]
        public Guid ActivityGuid { get; set; }
 
        [DisplayName("任务标题")]
        public string TaskTitle { get; set; }
 
        [DisplayName("任务类型：   0.正常处理   1.加签者   2.受托者")]
        public Nullable<byte> TaskType { get; set; }
 
        [DisplayName("任务状态")]
        public byte Status { get; set; }
 
        [DisplayName("任务所有者的用户ID")]
        public string Owner { get; set; }
 
        [DisplayName("实际执行者的用户ID")]
        public string Executor { get; set; }
 
        [DisplayName("创建时间")]
        public Nullable<DateTime> CreateTime { get; set; }
 
        [DisplayName("更新时间")]
        public Nullable<DateTime> UpdateTime { get; set; }
 
        public virtual RtInstance InstanceGuid_FK { get; set; }
    }
}
