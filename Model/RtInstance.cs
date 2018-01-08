using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    /// <summary>
    /// �ļ�˵��: ��Ϣʵ��
    /// ��    ��: JBO
    /// ��������: 2017��12��30��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
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
 
        [DisplayName("���̶���Guid")]
        public Guid RepoGuid { get; set; }
 
        [DisplayName("����ʵ������")]
        public string InstanceTitle { get; set; }
 
        [DisplayName("����״̬��0.��ʼ��1.�½�2.����3.����4.����")]
        public byte InstanceStatus { get; set; }
 
        [DisplayName("���̷�����")]
        public string Originator { get; set; }
 
        [DisplayName("���̷���ʱ��")]
        public Nullable<DateTime> StartTime { get; set; }
 
        [DisplayName("���̽���ʱ��")]
        public Nullable<DateTime> EndTime { get; set; }
 
        [DisplayName("ʵ�����̶�������")]
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
