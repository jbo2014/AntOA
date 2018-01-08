using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    /// <summary>
    /// �ļ�˵��: ��Ϣʵ��
    /// ��    ��: JBO
    /// ��������: 2017��12��30��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class SysRoleUser
    {
        [Key]
        public Guid RoleUserGuid { get; set; }
 
        [DisplayName("��ɫGuid")]
        public Guid RoleGuid { get; set; }
 
        [DisplayName("�û�Guid")]
        public Guid UserGuid { get; set; }
 
        public virtual SysRole RoleGuid_FK { get; set; }
        public virtual SysUser UserGuid_FK { get; set; }
    }
}
