using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Mapping
{
    /// <summary>
    /// 文件说明: 信息实体映射
    /// 作    者: 王俊波
    /// 生成日期: 2017-12-14
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    public class WfTaskMap : EntityTypeConfiguration<WfTask>
    {
      public WfTaskMap()
      {        
        //属性
        		this.HasKey(t => t.TaskGuid);		this.Property(t => t.TaskTitle).HasMaxLength(100);
        
        //表与列的对应
        this.ToTable("WfTask");
        		this.Property(t => t.TaskGuid).HasColumnName("TaskGuid");		this.Property(t => t.InstanceGuid).HasColumnName("InstanceGuid");		this.Property(t => t.NodeGuid).HasColumnName("NodeGuid");		this.Property(t => t.TaskTitle).HasColumnName("TaskTitle");		this.Property(t => t.TaskType).HasColumnName("TaskType");		this.Property(t => t.TaskStatus).HasColumnName("TaskStatus");		this.Property(t => t.TaskOwner).HasColumnName("TaskOwner");		this.Property(t => t.TaskActor).HasColumnName("TaskActor");		this.Property(t => t.Stamp).HasColumnName("Stamp");
        
        //外键关系
        		this.HasOptional(t => t.InstanceGuid_FK).WithMany(t => t.WfTask_InstanceGuidList).HasForeignKey(d => d.InstanceGuid);		this.HasOptional(t => t.NodeGuid_FK).WithMany(t => t.WfTask_NodeGuidList).HasForeignKey(d => d.NodeGuid);
      }
    }
}
