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
    public partial class WfForm
    {
        [Key]
        public Guid FormGuid { get; set; }

        [DisplayName("��Ӧ���̶����RepoGuid")]
        public Nullable<Guid> MasterGuid { get; set; }

        [DisplayName("��Ӧ���̶����е�TaskPage")]
        public Nullable<Guid> TaskPage { get; set; }

        [DisplayName("���ͣ���ʼ�����񡢹��������")]
        public string Type { get; set; }

        [DisplayName("������ ")]
        public string Name { get; set; }

        [DisplayName("��Html")]
        public string Html { get; set; }

        [DisplayName("����ʱ��")]
        public Nullable<DateTime> CreateTime { get; set; }

        [DisplayName("�����û�")]
        public Nullable<Guid> CreateUser { get; set; }

        [DisplayName("����ʱ��")]
        public Nullable<DateTime> UpdateTime { get; set; }

        [DisplayName("�����û�")]
        public Nullable<Guid> UpdateUser { get; set; }

        [DisplayName("�޸Ĵ���")]
        public Nullable<int> Released { get; set; }

        public virtual WfRepository MasterGuid_FK { get; set; }
 
    }
}
