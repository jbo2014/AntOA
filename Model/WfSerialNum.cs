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
    public partial class WfSerialNum
    {
        [Key]
        public Guid SerialGuid { get; set; }
 
        [DisplayName("�������")]
        public string SerialName { get; set; }
 
        [DisplayName("��ǰ���")]
        public string CurrentNum { get; set; }
 
        [DisplayName("����")]
        public int Step { get; set; }
 
        [DisplayName("����ַ�")]
        public string Filler { get; set; }
 
        [DisplayName("����ʱ��")]
        public DateTime CreateTime { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> UpdateTime { get; set; }
 
    }
}
