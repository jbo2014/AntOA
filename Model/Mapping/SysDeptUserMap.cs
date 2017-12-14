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
    public class SysDeptUserMap : EntityTypeConfiguration<SysDeptUser>
    {
      public SysDeptUserMap()
      {        
        //����
        		this.HasKey(t => t.DeptUserGuid);
        
        //�����еĶ�Ӧ
        this.ToTable("SysDeptUser");
        		this.Property(t => t.DeptUserGuid).HasColumnName("DeptUserGuid");		this.Property(t => t.DeptGuid).HasColumnName("DeptGuid");		this.Property(t => t.UserGuid).HasColumnName("UserGuid");
        
        //�����ϵ
        		this.HasOptional(t => t.DeptGuid_FK).WithMany(t => t.SysDeptUser_DeptGuidList).HasForeignKey(d => d.DeptGuid);		this.HasOptional(t => t.UserGuid_FK).WithMany(t => t.SysDeptUser_UserGuidList).HasForeignKey(d => d.UserGuid);
      }
    }
}
