using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ��Ϣʵ��ӳ��
    /// ��    ��: WJB
    /// ��������: 2017��12��26��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class SysDeptUserMap : EntityTypeConfiguration<SysDeptUser>
    {
      public SysDeptUserMap()
      {
        //����
        this.HasKey(t => t.DeptUserGuid);
        
        //����
        
        //�����еĶ�Ӧ
        this.ToTable("SysDeptUser");
        this.Property(t => t.DeptUserGuid).HasColumnName("DeptUserGuid");
        this.Property(t => t.DeptGuid).HasColumnName("DeptGuid");
        this.Property(t => t.UserGuid).HasColumnName("UserGuid");
        
         //�����ϵ
        this.HasRequired(t => t.DeptGuid_FK)
            .WithMany(t => t.SysDeptUser_DeptGuidList)
            .HasForeignKey(d => d.DeptGuid);
        this.HasRequired(t => t.UserGuid_FK)
            .WithMany(t => t.SysDeptUser_UserGuidList)
            .HasForeignKey(d => d.UserGuid);
      }
    }
}
