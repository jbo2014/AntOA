using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    /// <summary>
    /// �ļ�˵��: ��Ϣʵ��
    /// ��    ��: ������
    /// ��������: 2017-12-14
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class WfInstance
    {
        public WfInstance()
        {
            			this.WfNode_InstanceGuidList = new List<WfNode>();			this.WfTask_InstanceGuidList = new List<WfTask>();			this.WfTransition_InstanceGuidList = new List<WfTransition>();			this.WfVar_InstanceGuidList = new List<WfVar>();
        }

        		[Key]		public Guid InstanceGuid { get; set; }		[DisplayName("���̶���Guid")]		public Guid RepoGuid { get; set; }		[DisplayName("")]		public string InstanceTitle { get; set; }		[DisplayName("����ʵ������")]		public byte InstanceStatus { get; set; }		[DisplayName("����״̬")]		public Nullable<Guid> CurrentTask { get; set; }		[DisplayName("���̵�ǰ����")]		public Guid Originator { get; set; }		[DisplayName("���̷�����")]		public DateTime StartTime { get; set; }		[DisplayName("���̷���ʱ��")]		public Nullable<Guid> Terminator { get; set; }		[DisplayName("���̽�����")]		public Nullable<DateTime> EndTime { get; set; }		[DisplayName("���̽���ʱ��")]		public Nullable<byte[]> Stamp { get; set; } 
        
        		public virtual ICollection<WfNode> WfNode_InstanceGuidList { get; set; }		public virtual ICollection<WfTask> WfTask_InstanceGuidList { get; set; }		public virtual ICollection<WfTransition> WfTransition_InstanceGuidList { get; set; }		public virtual ICollection<WfVar> WfVar_InstanceGuidList { get; set; }
    }
}