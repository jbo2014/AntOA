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
    public partial class SysDeptUser
    {
        public SysDeptUser()
        {
            
        }

        		[Key]		public Guid DeptUserGuid { get; set; }		[DisplayName("����Guid")]		public Guid DeptGuid { get; set; }		[DisplayName("�û�Guid")]		public Guid UserGuid { get; set; } 
        
        
    }
}