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
    public partial class WfNode
    {
        public WfNode()
        {
            			this.WfTask_NodeGuidList = new List<WfTask>();
        }

        		[Key]		public Guid NodeGuid { get; set; }		[DisplayName("����ʵ��Guid")]		public Guid InstanceGuid { get; set; }		[DisplayName("���̶����нڵ�ID")]		public Nullable<string> StepDefID { get; set; }		[DisplayName("�ڵ�����")]		public byte NodeType { get; set; }		[DisplayName("�˻�ǰԭʼ�ڵ�Guid")]		public Nullable<Guid> RawNodeGuid { get; set; }		[DisplayName("��ʵ����������ID")]		public Nullable<Guid> Sponsor { get; set; }		[DisplayName("ͨ����")]		public Nullable<double> PassRate { get; set; }		[DisplayName("��ǩ����")]		public Nullable<byte> AddSign { get; set; }		[DisplayName("��ʼʱ��")]		public DateTime StartTime { get; set; }		[DisplayName("����ʱ��")]		public Nullable<DateTime> EndTime { get; set; } 
        
        		public virtual ICollection<WfTask> WfTask_NodeGuidList { get; set; }
    }
}