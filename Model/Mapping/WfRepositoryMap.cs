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
    public class WfRepositoryMap : EntityTypeConfiguration<WfRepository>
    {
      public WfRepositoryMap()
      {
        //主键
        this.HasKey(t => t.RepoGuid);
        
        //属性
        
        this.Property(t => t.Description)
            .HasMaxLength(100);
        
        this.Property(t => t.Version)
            .HasMaxLength(10);
        
        this.Property(t => t.BpmFile)
            .HasMaxLength(50);
        
        this.Property(t => t.BpmPath)
            .HasMaxLength(100);
        
        //表与列的对应
        this.ToTable("WfRepository");
        this.Property(t => t.RepoGuid).HasColumnName("RepoGuid");
        this.Property(t => t.Description).HasColumnName("Description");
        this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        this.Property(t => t.Version).HasColumnName("Version");
        this.Property(t => t.BpmFile).HasColumnName("BpmFile");
        this.Property(t => t.BpmPath).HasColumnName("BpmPath");
        this.Property(t => t.BpmContent).HasColumnName("BpmContent");
        this.Property(t => t.ProcessGuid).HasColumnName("ProcessGuid");
        
         //外键关系
        this.HasOptional(t => t.ProcessGuid_FK)
            .WithMany(t => t.WfRepository_ProcessGuidList)
            .HasForeignKey(d => d.ProcessGuid);
      }
    }
}
