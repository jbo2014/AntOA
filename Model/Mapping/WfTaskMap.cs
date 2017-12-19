using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ��Ϣʵ��ӳ��
    /// ��    ��: WJB
    /// ��������: 2017��12��18��
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
        
        this.Property(t => t.TaskTitle)
            .HasMaxLength(100);
        
        //�����еĶ�Ӧ
        this.ToTable("WfTask");
        this.Property(t => t.TaskGuid).HasColumnName("TaskGuid");
        this.Property(t => t.InstanceGuid).HasColumnName("InstanceGuid");
        this.Property(t => t.NodeGuid).HasColumnName("NodeGuid");
        this.Property(t => t.TaskTitle).HasColumnName("TaskTitle");
        this.Property(t => t.TaskType).HasColumnName("TaskType");
        this.Property(t => t.TaskStatus).HasColumnName("TaskStatus");
        this.Property(t => t.TaskOwner).HasColumnName("TaskOwner");
        this.Property(t => t.TaskActor).HasColumnName("TaskActor");
        
         //�����ϵ
        this.HasRequired(t => t.InstanceGuid_FK)
            .WithMany(t => t.WfTask_InstanceGuidList)
            .HasForeignKey(d => d.InstanceGuid);
        this.HasRequired(t => t.NodeGuid_FK)
            .WithMany(t => t.WfTask_NodeGuidList)
            .HasForeignKey(d => d.NodeGuid);
      }
    }
}
