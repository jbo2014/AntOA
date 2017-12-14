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
    public partial class SysDepartment
    {
        public SysDepartment()
        {
            			this.SysDeptUser_DeptGuidList = new List<SysDeptUser>();
        }

        		[Key]		public Guid DeptGuid { get; set; }		[DisplayName("��������")]		public string DeptName { get; set; }		[DisplayName("�ϼ�����Guid")]		public Guid HiDeptGuid { get; set; }		[DisplayName("���Ÿ�����")]		public Nullable<Guid> DeptLeader { get; set; } 
        
        		public virtual ICollection<SysDeptUser> SysDeptUser_DeptGuidList { get; set; }
    }
}