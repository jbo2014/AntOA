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
    public class WfRepositoryMap : EntityTypeConfiguration<WfRepository>
    {
      public WfRepositoryMap()
      {        
        //属性
        		this.HasKey(t => t.RepoGuid);		this.Property(t => t.Description).HasMaxLength(100);		this.Property(t => t.Version).HasMaxLength(10);		this.Property(t => t.BpmFile).HasMaxLength(50);		this.Property(t => t.BpmPath).HasMaxLength(100);
        
        //表与列的对应
        this.ToTable("WfRepository");
        		this.Property(t => t.RepoGuid).HasColumnName("RepoGuid");		this.Property(t => t.Description).HasColumnName("Description");		this.Property(t => t.CreateTime).HasColumnName("CreateTime");		this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");		this.Property(t => t.Stamp).HasColumnName("Stamp");		this.Property(t => t.Version).HasColumnName("Version");		this.Property(t => t.BpmFile).HasColumnName("BpmFile");		this.Property(t => t.BpmPath).HasColumnName("BpmPath");		this.Property(t => t.BpmContent).HasColumnName("BpmContent");		this.Property(t => t.ProcessGuid).HasColumnName("ProcessGuid");
        
        //外键关系
        
      }
    }
}
