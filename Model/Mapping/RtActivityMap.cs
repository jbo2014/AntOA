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
    public class RtActivityMap : EntityTypeConfiguration<RtActivity>
    {
      public RtActivityMap()
      {
        //����
        this.HasKey(t => t.ActivityGuid);
        
        //����
        
        this.Property(t => t.ActivityID)
            .HasMaxLength(10);
        
        //�����еĶ�Ӧ
        this.ToTable("RtNode");
        this.Property(t => t.ActivityGuid).HasColumnName("ActivityGuid");
        this.Property(t => t.InstanceGuid).HasColumnName("InstanceGuid");
        this.Property(t => t.ActivityID).HasColumnName("ActivityID");
        this.Property(t => t.ActivityType).HasColumnName("ActivityType");
        this.Property(t => t.RawNodeGuid).HasColumnName("RawNodeGuid");
        this.Property(t => t.Sponsor).HasColumnName("Sponsor");
        this.Property(t => t.PassRate).HasColumnName("PassRate");
        this.Property(t => t.AddSign).HasColumnName("AddSign");
        this.Property(t => t.TokensRequired).HasColumnName("TokensRequired");
        this.Property(t => t.TokensHad).HasColumnName("TokensHad");
        this.Property(t => t.FormGuid).HasColumnName("FormGuid");
        this.Property(t => t.StartTime).HasColumnName("StartTime");
        this.Property(t => t.EndTime).HasColumnName("EndTime");
        
         //�����ϵ
        this.HasRequired(t => t.InstanceGuid_FK)
            .WithMany(t => t.RtActivity_InstanceGuidList)
            .HasForeignKey(d => d.InstanceGuid);
      }
    }
}
