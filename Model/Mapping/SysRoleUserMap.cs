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
    public class SysRoleUserMap : EntityTypeConfiguration<SysRoleUser>
    {
      public SysRoleUserMap()
      {
        //����
        this.HasKey(t => t.RoleUserGuid);
        
        //����
        
        //�����еĶ�Ӧ
        this.ToTable("SysRoleUser");
        this.Property(t => t.RoleUserGuid).HasColumnName("RoleUserGuid");
        this.Property(t => t.RoleGuid).HasColumnName("RoleGuid");
        this.Property(t => t.UserGuid).HasColumnName("UserGuid");
        
         //�����ϵ
        this.HasRequired(t => t.RoleGuid_FK)
            .WithMany(t => t.SysRoleUser_RoleGuidList)
            .HasForeignKey(d => d.RoleGuid);
        this.HasRequired(t => t.UserGuid_FK)
            .WithMany(t => t.SysRoleUser_UserGuidList)
            .HasForeignKey(d => d.UserGuid);
      }
    }
}
