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
    public class RtTaskMap : EntityTypeConfiguration<RtTask>
    {
      public RtTaskMap()
      {
        //����
        this.HasKey(t => t.TaskGuid);
        
        //����
        
        this.Property(t => t.TaskTitle)
            .HasMaxLength(100);
        
        this.Property(t => t.Owner)
            .HasMaxLength(100);
        
        this.Property(t => t.Executor)
            .HasMaxLength(100);
        
        //�����еĶ�Ӧ
        this.ToTable("RtTask");
        this.Property(t => t.TaskGuid).HasColumnName("TaskGuid");
        this.Property(t => t.InstanceGuid).HasColumnName("InstanceGuid");
        this.Property(t => t.ActivityGuid).HasColumnName("ActivityGuid");
        this.Property(t => t.TaskTitle).HasColumnName("TaskTitle");
        this.Property(t => t.TaskType).HasColumnName("TaskType");
        this.Property(t => t.Status).HasColumnName("Status");
        this.Property(t => t.Owner).HasColumnName("Owner");
        this.Property(t => t.Executor).HasColumnName("Executor");
        this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        
         //�����ϵ
        this.HasRequired(t => t.InstanceGuid_FK)
            .WithMany(t => t.RtTask_InstanceGuidList)
            .HasForeignKey(d => d.InstanceGuid);
      }
    }
}
