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
    public class SysUserMap : EntityTypeConfiguration<SysUser>
    {
      public SysUserMap()
      {        
        //����
        		this.HasKey(t => t.UserGuid);		this.Property(t => t.UserID).HasMaxLength(50);		this.Property(t => t.UserPwd).HasMaxLength(50);		this.Property(t => t.UserName).HasMaxLength(50);		this.Property(t => t.Phone).HasMaxLength(12);		this.Property(t => t.Email).HasMaxLength(50);
        
        //�����еĶ�Ӧ
        this.ToTable("SysUser");
        		this.Property(t => t.UserGuid).HasColumnName("UserGuid");		this.Property(t => t.UserID).HasColumnName("UserID");		this.Property(t => t.UserPwd).HasColumnName("UserPwd");		this.Property(t => t.UserName).HasColumnName("UserName");		this.Property(t => t.UserSex).HasColumnName("UserSex");		this.Property(t => t.Phone).HasColumnName("Phone");		this.Property(t => t.Email).HasColumnName("Email");
        
        //�����ϵ
        
      }
    }
}
