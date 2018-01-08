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
    public partial class RtTask
    {
        [Key]
        public Guid TaskGuid { get; set; }
 
        [DisplayName("����ʵ��Guid")]
        public Guid InstanceGuid { get; set; }

        [DisplayName("�ʵ��Guid")]
        public Guid ActivityGuid { get; set; }
 
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
        public Nullable<DateTime> CreateTime { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> UpdateTime { get; set; }
 
        public virtual RtInstance InstanceGuid_FK { get; set; }
    }
}
