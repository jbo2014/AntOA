using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    /// <summary>
    /// �ļ�˵��: ��Ϣʵ��
    /// ��    ��: WJB
    /// ��������: 2017��12��26��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class WfInstance
    {
        public WfInstance()
        {
          this.WfNode_InstanceGuidList = new List<WfNode>();
          this.WfTask_InstanceGuidList = new List<WfTask>();
          this.WfTransition_InstanceGuidList = new List<WfTransition>();
          this.WfVar_InstanceGuidList = new List<WfVar>();
        }
 
        [Key]
        public Guid InstanceGuid { get; set; }
 
        [DisplayName("���̶���Guid")]
        public Guid RepoGuid { get; set; }
 
        [DisplayName("����ʵ������")]
        public string InstanceTitle { get; set; }
 
        [DisplayName("����״̬��0.��ʼ��1.�½�2.����3.����4.����")]
        public byte InstanceStatus { get; set; }
 
        [DisplayName("���̵�ǰ����")]
        public Nullable<Guid> CurrentTask { get; set; }
 
        [DisplayName("���̷�����")]
        public string Originator { get; set; }
 
        [DisplayName("���̷���ʱ��")]
        public DateTime StartTime { get; set; }
 
        [DisplayName("���̽�����")]
        public Nullable<Guid> Terminator { get; set; }
 
        [DisplayName("���̽���ʱ��")]
        public Nullable<DateTime> EndTime { get; set; }
 
        public virtual ICollection<WfNode> WfNode_InstanceGuidList { get; set; }
        public virtual ICollection<WfTask> WfTask_InstanceGuidList { get; set; }
        public virtual ICollection<WfTransition> WfTransition_InstanceGuidList { get; set; }
        public virtual ICollection<WfVar> WfVar_InstanceGuidList { get; set; }
        public virtual WfRepository RepoGuid_FK { get; set; }
    }
}
