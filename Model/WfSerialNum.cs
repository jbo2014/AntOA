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
    public partial class WfSerialNum
    {
        public WfSerialNum()
        {
            
        }

        		[Key]		public Guid SerialGuid { get; set; }		[DisplayName("�������")]		public string SerialName { get; set; }		[DisplayName("��ǰ���")]		public string CurrentNum { get; set; }		[DisplayName("����")]		public int Step { get; set; }		[DisplayName("����ַ�")]		public Nullable<string> Filler { get; set; }		[DisplayName("����ʱ��")]		public DateTime CreateTime { get; set; }		[DisplayName("����ʱ��")]		public Nullable<DateTime> UpdateTime { get; set; } 
        
        
    }
}