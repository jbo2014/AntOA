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
    public class SysRoleUserMap : EntityTypeConfiguration<SysRoleUser>
    {
      public SysRoleUserMap()
      {        
        //����
        		this.HasKey(t => t.RoleUserGuid);
        
        //�����еĶ�Ӧ
        this.ToTable("SysRoleUser");
        		this.Property(t => t.RoleUserGuid).HasColumnName("RoleUserGuid");		this.Property(t => t.RoleGuid).HasColumnName("RoleGuid");		this.Property(t => t.UserGuid).HasColumnName("UserGuid");
        
        //�����ϵ
        		this.HasOptional(t => t.RoleGuid_FK).WithMany(t => t.SysRoleUser_RoleGuidList).HasForeignKey(d => d.RoleGuid);		this.HasOptional(t => t.UserGuid_FK).WithMany(t => t.SysRoleUser_UserGuidList).HasForeignKey(d => d.UserGuid);
      }
    }
}
