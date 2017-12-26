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
    public partial class FmData
    {
        [Key]
        public Guid FormGuid { get; set; }
 
        [DisplayName("�ؼ�ID")]
        public string FormID { get; set; }
 
        public string WidgetID { get; set; }
 
        public string Value { get; set; }
 
    }
}
