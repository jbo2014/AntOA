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
    public partial class WfToken
    {
        [Key]
        public Guid TokenGuid { get; set; }
 
        [DisplayName("����ʵ��")]
        public Guid InstanceGuid { get; set; }
 
        [DisplayName("��Token")]
        public Nullable<Guid> ParentToken { get; set; }
 
        [DisplayName("���̶����е�Ԫ��Guid")]
        public string ElementID { get; set; }
 
        [DisplayName("״̬��0.�ȴ���1.���2.������")]
        public Nullable<byte> Status { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> CreateTime { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> UpdateTime { get; set; }
 
    }
}
