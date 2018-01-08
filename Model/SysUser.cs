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
    public partial class SysUser
    {
        public SysUser()
        {
          this.SysDeptUser_UserGuidList = new List<SysDeptUser>();
          this.SysRoleUser_UserGuidList = new List<SysRoleUser>();
        }
 
        [Key]
        public Guid UserGuid { get; set; }
 
        [DisplayName("��¼�ʺ�")]
        public string UserID { get; set; }
 
        [DisplayName("��¼����")]
        public string UserPwd { get; set; }
 
        [DisplayName("�û�����")]
        public string UserName { get; set; }
 
        [DisplayName("�Ա�")]
        public Nullable<bool> UserSex { get; set; }
 
        [DisplayName("�ֻ�")]
        public string Phone { get; set; }
 
        [DisplayName("����")]
        public string Email { get; set; }
 
        public virtual ICollection<SysDeptUser> SysDeptUser_UserGuidList { get; set; }
        public virtual ICollection<SysRoleUser> SysRoleUser_UserGuidList { get; set; }
    }
}
