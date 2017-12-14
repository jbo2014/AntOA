using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    /// <summary>
    /// �ļ�˵��: ��Ϣʵ��
    /// ��    ��: ������
    /// ��������: 2017-12-14
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class WfRepository
    {
        public WfRepository()
        {
            			this.WfInstance_RepoGuidList = new List<WfInstance>();
        }

        		[Key]		public Guid RepoGuid { get; set; }		[DisplayName("")]		public Nullable<string> Description { get; set; }		[DisplayName("")]		public DateTime CreateTime { get; set; }		[DisplayName("")]		public Nullable<DateTime> UpdateTime { get; set; }		[DisplayName("����")]		public Nullable<byte[]> Stamp { get; set; }		[DisplayName("����ʱ��")]		public Nullable<string> Version { get; set; }		[DisplayName("����ʱ��")]		public string BpmFile { get; set; }		[DisplayName("ʱ���")]		public string BpmPath { get; set; }		[DisplayName("���̶���İ汾��")]		public Nullable<string> BpmContent { get; set; }		[DisplayName("���̶���XML�ļ�������")]		public Nullable<Guid> ProcessGuid { get; set; } 
        
        		public virtual ICollection<WfInstance> WfInstance_RepoGuidList { get; set; }
    }
}