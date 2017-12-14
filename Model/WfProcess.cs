using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    /// <summary>
    /// �ļ�˵��: ���̶������Ϣʵ��
    /// ��    ��: ������
    /// ��������: 2017-12-14
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class WfProcess
    {
        public WfProcess()
        {
            
        }

        		[Key]		public Guid ProcessGuid { get; set; }		[DisplayName("���̶�������")]		public Nullable<string> ProcessName { get; set; }		[DisplayName("���汾����ǰʱ���½�����ʱʹ�õ����̰汾��")]		public Nullable<string> MasterVer { get; set; }		[DisplayName("����ʱ��")]		public DateTime CreateTime { get; set; }		[DisplayName("���¸���ʱ��")]		public Nullable<DateTime> UpdateTime { get; set; }		[DisplayName("ʱ���")]		public Nullable<byte[]> Stamp { get; set; }		[DisplayName("״̬��0δ������1�ѷ�����2�ع��У�3������")]		public Nullable<byte> Status { get; set; } 
        
        
    }
}