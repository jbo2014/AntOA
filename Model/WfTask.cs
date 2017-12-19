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
    /// ��������: 2017��12��18��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class WfTask
    {
        [Key]
        public Guid TaskGuid { get; set; }
 
        [DisplayName("����ʵ��Guid")]
        public Guid InstanceGuid { get; set; }
 
        [DisplayName("ʵ���ڵ�Guid")]
        public Guid NodeGuid { get; set; }
 
        [DisplayName("�������")]
        public string TaskTitle { get; set; }
 
        [DisplayName("�������ͣ�   0.��������   1.��ǩ��   2.������")]
        public Nullable<byte> TaskType { get; set; }
 
        [DisplayName("����״̬")]
        public byte TaskStatus { get; set; }
 
        [DisplayName("���������ߵ��û�ID")]
        public Guid TaskOwner { get; set; }
 
        [DisplayName("ʵ��ִ���ߵ��û�ID")]
        public Guid TaskActor { get; set; }
 
        public virtual WfInstance InstanceGuid_FK { get; set; }
        public virtual WfNode NodeGuid_FK { get; set; }
    }
}
