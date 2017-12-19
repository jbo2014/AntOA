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
    public partial class WfRepository
    {
        public WfRepository()
        {
          this.WfInstance_RepoGuidList = new List<WfInstance>();
        }
 
        [Key]
        public Guid RepoGuid { get; set; }
 
        [DisplayName("����")]
        public string Description { get; set; }
 
        [DisplayName("����ʱ��")]
        public DateTime CreateTime { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> UpdateTime { get; set; }
 
        [DisplayName("���̶���İ汾��")]
        public string Version { get; set; }
 
        [DisplayName("���̶���XML�ļ�������")]
        public string BpmFile { get; set; }
 
        [DisplayName("���̶���XML�ļ���·��")]
        public string BpmPath { get; set; }
 
        [DisplayName("���̶����XML")]
        public string BpmContent { get; set; }
 
        [DisplayName("���̶���Guid")]
        public Nullable<Guid> ProcessGuid { get; set; }
 
        public virtual ICollection<WfInstance> WfInstance_RepoGuidList { get; set; }
        public virtual WfProcess ProcessGuid_FK { get; set; }
    }
}
