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
    public class WfInstanceMap : EntityTypeConfiguration<WfInstance>
    {
      public WfInstanceMap()
      {        
        //属性
        		this.HasKey(t => t.InstanceGuid);		this.Property(t => t.InstanceTitle).HasMaxLength(100);
        
        //表与列的对应
        this.ToTable("WfInstance");
        		this.Property(t => t.InstanceGuid).HasColumnName("InstanceGuid");		this.Property(t => t.RepoGuid).HasColumnName("RepoGuid");		this.Property(t => t.InstanceTitle).HasColumnName("InstanceTitle");		this.Property(t => t.InstanceStatus).HasColumnName("InstanceStatus");		this.Property(t => t.CurrentTask).HasColumnName("CurrentTask");		this.Property(t => t.Originator).HasColumnName("Originator");		this.Property(t => t.StartTime).HasColumnName("StartTime");		this.Property(t => t.Terminator).HasColumnName("Terminator");		this.Property(t => t.EndTime).HasColumnName("EndTime");		this.Property(t => t.Stamp).HasColumnName("Stamp");
        
        //外键关系
        		this.HasOptional(t => t.RepoGuid_FK).WithMany(t => t.WfInstance_RepoGuidList).HasForeignKey(d => d.RepoGuid);
      }
    }
}
