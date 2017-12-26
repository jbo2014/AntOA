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
    public partial class WfTask
    {
        [Key]
        public Guid TaskGuid { get; set; }
 
        [DisplayName("����ʵ��Guid")]
        public Guid InstanceGuid { get; set; }
 
        [DisplayName("ʵ���ڵ�Guid")]
        public string NodeID { get; set; }
 
        [DisplayName("�������")]
        public string TaskTitle { get; set; }
 
        [DisplayName("�������ͣ�   0.��������   1.��ǩ��   2.������")]
        public Nullable<byte> TaskType { get; set; }
 
        [DisplayName("����״̬")]
        public byte Status { get; set; }
 
        [DisplayName("���������ߵ��û�ID")]
        public string Owner { get; set; }
 
        [DisplayName("ʵ��ִ���ߵ��û�ID")]
        public string Executor { get; set; }
 
        [DisplayName("����ʱ��")]
        public DateTime CreateTime { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> UpdateTime { get; set; }
 
        public Nullable<Guid> NodeGuid { get; set; }
 
        public virtual WfInstance InstanceGuid_FK { get; set; }
    }
}
