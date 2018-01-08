using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ��Ϣʵ��ӳ��
    /// ��    ��: JBO
    /// ��������: 2017��12��30��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class SysRoleMap : EntityTypeConfiguration<SysRole>
    {
      public SysRoleMap()
      {
        //����
        this.HasKey(t => t.RoleGuid);
        
        //����
        
        this.Property(t => t.RoleName)
            .HasMaxLength(100);
        
        //�����еĶ�Ӧ
        this.ToTable("SysRole");
        this.Property(t => t.RoleGuid).HasColumnName("RoleGuid");
        this.Property(t => t.RoleName).HasColumnName("RoleName");
        
      }
    }
}
