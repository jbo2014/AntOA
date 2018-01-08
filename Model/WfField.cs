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
    public partial class WfField
    {
        [Key]
        public Guid FieldGuid { get; set; }

        [DisplayName("���̶���RepoGuid")]
        public Guid MasterGuid { get; set; }

        [DisplayName("����")]
        public string Name { get; set; }

        [DisplayName("����")]
        public string Alias { get; set; }

        [DisplayName("���ͣ���ӦCodeTable��FieldType")]
        public string Type { get; set; }

        [DisplayName("�Ƿ�������")]
        public Nullable<bool> IsArray { get; set; }

        [DisplayName("������")]
        public string GroupName { get; set; }

        [DisplayName("��ʽ")]
        public string Format { get; set; }

        [DisplayName("��ֵ")]
        public string Value { get; set; }

        [DisplayName("������")]
        public string Description { get; set; }

        public virtual WfRepository MasterGuid_FK { get; set; }
 
    }
}
