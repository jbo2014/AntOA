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
    public partial class SysRoleUser
    {
        public SysRoleUser()
        {
            
        }

        		[Key]		public Guid RoleUserGuid { get; set; }		[DisplayName("��ɫGuid")]		public Guid RoleGuid { get; set; }		[DisplayName("�û�Guid")]		public Guid UserGuid { get; set; } 
        
        
    }
}