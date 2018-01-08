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
    public class WfFormMap : EntityTypeConfiguration<WfForm>
    {
      public WfFormMap()
      {
        //主键
        this.HasKey(t => t.FormGuid);
        
        //属性
        
        this.Property(t => t.Type)
            .HasMaxLength(50);
        
        this.Property(t => t.Name)
            .HasMaxLength(100);
        
        //表与列的对应
        this.ToTable("WfForm");
        this.Property(t => t.FormGuid).HasColumnName("FormGuid");
        this.Property(t => t.Type).HasColumnName("Type");
        this.Property(t => t.Html).HasColumnName("Html");
        this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        this.Property(t => t.Name).HasColumnName("Name");
        this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        this.Property(t => t.Released).HasColumnName("Released");

        //外键关系
        this.HasRequired(t => t.MasterGuid_FK)
            .WithMany(t => t.WfForm_RepoGuidList)
            .HasForeignKey(d => d.MasterGuid);
        
      }
    }
}
