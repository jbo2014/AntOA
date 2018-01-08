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
    public partial class RtTransition
    {
        [Key]
        public Guid TransferGuid { get; set; }
 
        [DisplayName("����ʵ��Guid")]
        public Guid InstanceGuid { get; set; }
 
        //[DisplayName("ת������")]
        //public byte TransferType { get; set; }

        [DisplayName("����")]
        public string Condition { get; set; }
 
        [DisplayName("�����������")]
        public string ConditionResult { get; set; }
 
        [DisplayName("ԭ�ڵ�Guid")]
        public Guid SourceGuid { get; set; }
 
        [DisplayName("Ŀ��ڵ�Guid")]
        public Guid TargetGuid { get; set; }
 
        public virtual RtInstance InstanceGuid_FK { get; set; }
    }
}
