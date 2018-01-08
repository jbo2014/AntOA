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
    public partial class RtInstance
    {
        public RtInstance()
        {
          this.RtActivity_InstanceGuidList = new List<RtActivity>();
          this.RtTask_InstanceGuidList = new List<RtTask>();
          this.RtTransition_InstanceGuidList = new List<RtTransition>();
          this.RtField_InstanceGuidList = new List<RtField>();
          this.RtForm_InstanceGuidList = new List<RtForm>();
          this.RtToken_InstanceGuidList = new List<RtToken>();
        }
 
        [Key]
        public Guid InstanceGuid { get; set; }
 
        [DisplayName("流程定义Guid")]
        public Guid RepoGuid { get; set; }
 
        [DisplayName("流程实例名称")]
        public string InstanceTitle { get; set; }
 
        [DisplayName("流程状态：0.初始化1.新建2.运行3.挂起4.结束")]
        public byte InstanceStatus { get; set; }
 
        [DisplayName("流程发起人")]
        public string Originator { get; set; }
 
        [DisplayName("流程发起时间")]
        public Nullable<DateTime> StartTime { get; set; }
 
        [DisplayName("流程结束时间")]
        public Nullable<DateTime> EndTime { get; set; }
 
        [DisplayName("实例流程定义内容")]
        public string ProcessXml { get; set; }

        public virtual ICollection<RtActivity> RtActivity_InstanceGuidList { get; set; }
        public virtual ICollection<RtTask> RtTask_InstanceGuidList { get; set; }
        public virtual ICollection<RtTransition> RtTransition_InstanceGuidList { get; set; }
        public virtual ICollection<RtField> RtField_InstanceGuidList { get; set; }
        public virtual ICollection<RtForm> RtForm_InstanceGuidList { get; set; }
        public virtual ICollection<RtToken> RtToken_InstanceGuidList { get; set; }
        public virtual WfRepository RepoGuid_FK { get; set; }
    }
}
