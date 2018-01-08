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
    public partial class RtToken
    {
        [Key]
        public Guid TokenGuid { get; set; }
 
        [DisplayName("����ʵ��")]
        public Guid InstanceGuid { get; set; }

        [DisplayName("��token")]
        public Guid PreToken { get; set; }
 
        //[DisplayName("��Token")]
        //public Nullable<Guid> ParentToken { get; set; }
 
        [DisplayName("���̶����е�Ԫ��Guid")]
        public string ElementID { get; set; }
 
        [DisplayName("״̬��0.�ȴ���1.���2.������")]
        public Nullable<byte> Status { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> CreateTime { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> UpdateTime { get; set; }

        public virtual RtInstance InstanceGuid_FK { get; set; }
 
    }
}
