using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ��Ϣʵ��ӳ��
    /// ��    ��: ������
    /// ��������: 2017-12-14
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    public class SysDepartmentMap : EntityTypeConfiguration<SysDepartment>
    {
      public SysDepartmentMap()
      {        
        //����
        		this.HasKey(t => t.DeptGuid);		this.Property(t => t.DeptName).HasMaxLength(100);
        
        //�����еĶ�Ӧ
        this.ToTable("SysDepartment");
        		this.Property(t => t.DeptGuid).HasColumnName("DeptGuid");		this.Property(t => t.DeptName).HasColumnName("DeptName");		this.Property(t => t.HiDeptGuid).HasColumnName("HiDeptGuid");		this.Property(t => t.DeptLeader).HasColumnName("DeptLeader");
        
        //�����ϵ
        
      }
    }
}
