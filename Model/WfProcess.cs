using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    /// <summary>
    /// �ļ�˵��: ���̶������Ϣʵ��
    /// ��    ��: WJB
    /// ��������: 2017��12��18��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class WfProcess
    {
        public WfProcess()
        {
          this.WfRepository_ProcessGuidList = new List<WfRepository>();
        }
 
        [Key]
        public Guid ProcessGuid { get; set; }
 
        [DisplayName("���̶�������")]
        public string ProcessName { get; set; }
 
        [DisplayName("���汾����ǰʱ���½�����ʱʹ�õ����̰汾��")]
        public string MasterVer { get; set; }
 
        [DisplayName("����ʱ��")]
        public DateTime CreateTime { get; set; }
 
        [DisplayName("���¸���ʱ��")]
        public Nullable<DateTime> UpdateTime { get; set; }

        [DisplayName("����ʱ��")]
        public byte[] Stamp { get; set; }
 
        [DisplayName("״̬��0δ������1�ѷ�����2�ع��У�3������")]
        public Nullable<byte> Status { get; set; }
 
        public virtual ICollection<WfRepository> WfRepository_ProcessGuidList { get; set; }
    }
}
