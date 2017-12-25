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
 
        [DisplayName("����ʵ���Ľڵ�GUID")]
        public Guid NodeGuID { get; set; }

        [DisplayName("���̶���Ľڵ�ID")]
        public string NodeID { get; set; }
 
        [DisplayName("�������")]
        public string TaskTitle { get; set; }
 
        [DisplayName("�������ͣ�   0.��������   1.��ǩ��   2.������")]
        public Nullable<byte> TaskType { get; set; }
 
        [DisplayName("����״̬�� 0.δ���� 1.������ 2.���� 3.���")]
        public byte TaskStatus { get; set; }
 
        [DisplayName("���������ߵ��û�ID")]
        public Guid Owner { get; set; }
 
        [DisplayName("ʵ��ִ���ߵ��û�ID")]
        public Guid Executor { get; set; }
 
        public virtual WfInstance InstanceGuid_FK { get; set; }
        public virtual WfNode NodeGuid_FK { get; set; }
    }
}
