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
    public partial class SysRole
    {
        public SysRole()
        {
          this.SysRoleUser_RoleGuidList = new List<SysRoleUser>();
        }
 
        [Key]
        public Guid RoleGuid { get; set; }
 
        [DisplayName("��ɫ����")]
        public string RoleName { get; set; }
 
        public virtual ICollection<SysRoleUser> SysRoleUser_RoleGuidList { get; set; }
    }
}
