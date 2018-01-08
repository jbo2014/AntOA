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
    public partial class CodeTable
    {
        [Key]
        public string CodeCD { get; set; }
 
        [DisplayName("����")]
        public string Group { get; set; }
 
        [DisplayName("����")]
        public string Name { get; set; }
 
        [DisplayName("��ֵ")]
        public int Value { get; set; }
 
        [DisplayName("����˳��")]
        public Nullable<int> Sort { get; set; }
 
        [DisplayName("����")]
        public string Description { get; set; }
 
    }
}
