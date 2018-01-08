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
    public class RtInstanceMap : EntityTypeConfiguration<RtInstance>
    {
      public RtInstanceMap()
      {
        //����
        this.HasKey(t => t.InstanceGuid);
        
        //����
        
        this.Property(t => t.InstanceTitle)
            .HasMaxLength(100);
        
        this.Property(t => t.Originator)
            .HasMaxLength(100);
        
        //�����еĶ�Ӧ
        this.ToTable("RtInstance");
        this.Property(t => t.InstanceGuid).HasColumnName("InstanceGuid");
        this.Property(t => t.RepoGuid).HasColumnName("RepoGuid");
        this.Property(t => t.InstanceTitle).HasColumnName("InstanceTitle");
        this.Property(t => t.InstanceStatus).HasColumnName("InstanceStatus");
        //this.Property(t => t.CurrentTask).HasColumnName("CurrentTask");
        this.Property(t => t.Originator).HasColumnName("Originator");
        this.Property(t => t.StartTime).HasColumnName("StartTime");
        //this.Property(t => t.Terminator).HasColumnName("Terminator");
        this.Property(t => t.EndTime).HasColumnName("EndTime");
        this.Property(t => t.ProcessXml).HasColumnName("ProcessXml");
        
         //�����ϵ
        this.HasRequired(t => t.RepoGuid_FK)
            .WithMany(t => t.RtInstance_RepoGuidList)
            .HasForeignKey(d => d.RepoGuid);
      }
    }
}
