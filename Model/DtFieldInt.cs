using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    /// <summary>
    /// �ļ�˵��: �������ݴ洢��Ϣʵ��
    /// ��    ��: JBO
    /// ��������: 2017��12��30��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class DtFieldInt
    {
        [Key]
        public Guid ColumnGuid { get; set; }
 
        [DisplayName("��Ӧ����ʵ��Guid")]
        public Guid InstanceGuid { get; set; }
 
        [DisplayName("����")]
        public string Names { get; set; }
 
        [DisplayName("��ֵ")]
        public Nullable<int> Value { get; set; }
 
        [DisplayName("������")]
        public string Description { get; set; }
 
    }
}
