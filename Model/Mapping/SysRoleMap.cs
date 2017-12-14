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
    public class SysRoleMap : EntityTypeConfiguration<SysRole>
    {
      public SysRoleMap()
      {        
        //����
        		this.HasKey(t => t.RoleGuid);		this.Property(t => t.RoleName).HasMaxLength(100);
        
        //�����еĶ�Ӧ
        this.ToTable("SysRole");
        		this.Property(t => t.RoleGuid).HasColumnName("RoleGuid");		this.Property(t => t.RoleName).HasColumnName("RoleName");
        
        //�����ϵ
        
      }
    }
}
