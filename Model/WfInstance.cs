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
    public partial class WfInstance
    {
        public WfInstance()
        {
            			this.WfNode_InstanceGuidList = new List<WfNode>();			this.WfTask_InstanceGuidList = new List<WfTask>();			this.WfTransition_InstanceGuidList = new List<WfTransition>();			this.WfVar_InstanceGuidList = new List<WfVar>();
        }

        		[Key]		public Guid InstanceGuid { get; set; }		[DisplayName("流程定义Guid")]		public Guid RepoGuid { get; set; }		[DisplayName("")]		public string InstanceTitle { get; set; }		[DisplayName("流程实例名称")]		public byte InstanceStatus { get; set; }		[DisplayName("流程状态")]		public Nullable<Guid> CurrentTask { get; set; }		[DisplayName("流程当前任务")]		public Guid Originator { get; set; }		[DisplayName("流程发起人")]		public DateTime StartTime { get; set; }		[DisplayName("流程发起时间")]		public Nullable<Guid> Terminator { get; set; }		[DisplayName("流程结束人")]		public Nullable<DateTime> EndTime { get; set; }		[DisplayName("流程结束时间")]		public Nullable<byte[]> Stamp { get; set; } 
        
        		public virtual ICollection<WfNode> WfNode_InstanceGuidList { get; set; }		public virtual ICollection<WfTask> WfTask_InstanceGuidList { get; set; }		public virtual ICollection<WfTransition> WfTransition_InstanceGuidList { get; set; }		public virtual ICollection<WfVar> WfVar_InstanceGuidList { get; set; }
    }
}