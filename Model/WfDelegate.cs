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
    public partial class WfDelegate
    {
        [Key]
        public Guid DelegateGuid { get; set; }
 
        [DisplayName("ί����Guid")]
        public Guid PrincipalGuid { get; set; }
 
        [DisplayName("������Guid")]
        public Guid TrusteeGuid { get; set; }
 
        [DisplayName("��Ȩ���ͣ�   1.��ʱί�У�   2.ʵ����   3.���̶���ί�У�   4.��ɫί�У�   5.��ȫ��Ȩ")]
        public byte DelegateType { get; set; }
 
        [DisplayName("0�����̶��塢����ڵ㡢ʵ����ʵ������5�������Guid")]
        public string ObjectGuids { get; set; }
 
        [DisplayName("״̬")]
        public byte Status { get; set; }
 
        [DisplayName("��Чʱ��")]
        public DateTime EffectTime { get; set; }
 
        [DisplayName("ʧЧʱ��")]
        public Nullable<DateTime> ExpireTime { get; set; }
 
    }
}
