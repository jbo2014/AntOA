using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    /// <summary>
    /// �ļ�˵��: �ʵ��
    /// ��    ��: JBO
    /// ��������: 2017��12��30��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class RtActivity
    {
        [Key]
        public Guid ActivityGuid { get; set; }
 
        [DisplayName("����ʵ��Guid")]
        public Guid InstanceGuid { get; set; }
 
        [DisplayName("���̶����нڵ�ID")]
        public string ActivityID { get; set; }
 
        [DisplayName("�ڵ�����")]
        public byte ActivityType { get; set; }
 
        [DisplayName("�˻�ǰԭʼ�ڵ�Guid")]
        public Nullable<Guid> RawNodeGuid { get; set; }
 
        [DisplayName("��ʵ����������ID")]
        public Nullable<Guid> Sponsor { get; set; }
 
        [DisplayName("ͨ����")]
        public Nullable<double> PassRate { get; set; }
 
        [DisplayName("��ǩ����")]
        public Nullable<byte> AddSign { get; set; }

        [DisplayName("��Ҫ��������")]
        public int TokensRequired { get; set; }

        [DisplayName("ӵ�е�������")]
        public int TokensHad { get; set; }

        [DisplayName("�û�����󶨵ı�ʵ��Guid")]
        public Guid FormGuid { get; set; }

        [DisplayName("�û�����󶨵ı�����id")]
        public Guid TaskPage { get; set; }
 
        [DisplayName("��ʼʱ��")]
        public Nullable<DateTime> StartTime { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> EndTime { get; set; }
 
        public virtual RtInstance InstanceGuid_FK { get; set; }
    }
}
