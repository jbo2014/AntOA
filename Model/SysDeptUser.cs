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
    /// ��������: 2017��12��18��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class SysDeptUser
    {
        [Key]
        public Guid DeptUserGuid { get; set; }
 
        [DisplayName("����Guid")]
        public Guid DeptGuid { get; set; }
 
        [DisplayName("�û�Guid")]
        public Guid UserGuid { get; set; }
 
        public virtual SysDepartment DeptGuid_FK { get; set; }
        public virtual SysUser UserGuid_FK { get; set; }
    }
}
