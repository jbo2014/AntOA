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
    public partial class WfVar
    {
        public WfVar()
        {
            
        }

        		[Key]		public Guid ParamGuid { get; set; }		[DisplayName("����ʵ��Guid")]		public Guid InstanceGuid { get; set; }		[DisplayName("���̶���ı�����")]		public string ParamName { get; set; }		[DisplayName("����ֵ")]		public string Value { get; set; } 
        
        
    }
}