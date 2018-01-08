using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Mapping
{
    /// <summary>
    /// 文件说明: 信息实体映射
    /// 作    者: JBO
    /// 生成日期: 2017年12月30日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class RtTaskMap : EntityTypeConfiguration<RtTask>
    {
      public RtTaskMap()
      {
        //主键
        this.HasKey(t => t.TaskGuid);
        
        //属性
        
        this.Property(t => t.TaskTitle)
            .HasMaxLength(100);
        
        this.Property(t => t.Owner)
            .HasMaxLength(100);
        
        this.Property(t => t.Executor)
            .HasMaxLength(100);
        
        //表与列的对应
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
        
         //外键关系
        this.HasRequired(t => t.InstanceGuid_FK)
            .WithMany(t => t.RtTask_InstanceGuidList)
            .HasForeignKey(d => d.InstanceGuid);
      }
    }
}
