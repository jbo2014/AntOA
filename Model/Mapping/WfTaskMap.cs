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
    public class WfTaskMap : EntityTypeConfiguration<WfTask>
    {
      public WfTaskMap()
      {
        //����
        this.HasKey(t => t.TaskGuid);
        
        //����
        
        this.Property(t => t.NodeID)
            .HasMaxLength(50);
        
        this.Property(t => t.TaskTitle)
            .HasMaxLength(100);
        
        this.Property(t => t.Owner)
            .HasMaxLength(100);
        
        this.Property(t => t.Executor)
            .HasMaxLength(100);
        
        //�����еĶ�Ӧ
        this.ToTable("WfTask");
        this.Property(t => t.TaskGuid).HasColumnName("TaskGuid");
        this.Property(t => t.InstanceGuid).HasColumnName("InstanceGuid");
        this.Property(t => t.NodeID).HasColumnName("NodeID");
        this.Property(t => t.TaskTitle).HasColumnName("TaskTitle");
        this.Property(t => t.TaskType).HasColumnName("TaskType");
        this.Property(t => t.Status).HasColumnName("Status");
        this.Property(t => t.Owner).HasColumnName("Owner");
        this.Property(t => t.Executor).HasColumnName("Executor");
        this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        this.Property(t => t.NodeGuid).HasColumnName("NodeGuid");
        
         //�����ϵ
        this.HasRequired(t => t.InstanceGuid_FK)
            .WithMany(t => t.WfTask_InstanceGuidList)
            .HasForeignKey(d => d.InstanceGuid);
      }
    }
}
