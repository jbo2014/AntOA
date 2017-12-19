using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Mapping
{
    /// <summary>
    /// 文件说明: 信息实体映射
    /// 作    者: WJB
    /// 生成日期: 2017年12月18日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class WfTaskMap : EntityTypeConfiguration<WfTask>
    {
      public WfTaskMap()
      {
        //主键
        this.HasKey(t => t.TaskGuid);
        
        //属性
        
        this.Property(t => t.TaskTitle)
            .HasMaxLength(100);
        
        //表与列的对应
        this.ToTable("WfTask");
        this.Property(t => t.TaskGuid).HasColumnName("TaskGuid");
        this.Property(t => t.InstanceGuid).HasColumnName("InstanceGuid");
        this.Property(t => t.NodeGuid).HasColumnName("NodeGuid");
        this.Property(t => t.TaskTitle).HasColumnName("TaskTitle");
        this.Property(t => t.TaskType).HasColumnName("TaskType");
        this.Property(t => t.TaskStatus).HasColumnName("TaskStatus");
        this.Property(t => t.TaskOwner).HasColumnName("TaskOwner");
        this.Property(t => t.TaskActor).HasColumnName("TaskActor");
        
         //外键关系
        this.HasRequired(t => t.InstanceGuid_FK)
            .WithMany(t => t.WfTask_InstanceGuidList)
            .HasForeignKey(d => d.InstanceGuid);
        this.HasRequired(t => t.NodeGuid_FK)
            .WithMany(t => t.WfTask_NodeGuidList)
            .HasForeignKey(d => d.NodeGuid);
      }
    }
}
