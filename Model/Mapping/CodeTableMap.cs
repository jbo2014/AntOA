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
    public class CodeTableMap : EntityTypeConfiguration<CodeTable>
    {
      public CodeTableMap()
      {
        //主键
        this.HasKey(t => t.CodeCD);
        
        //属性
        
        this.Property(t => t.Group)
            .HasMaxLength(100);
        
        this.Property(t => t.Name)
            .HasMaxLength(100);
        
        this.Property(t => t.Description)
            .HasMaxLength(50);
        
        //表与列的对应
        this.ToTable("CodeTable");
        this.Property(t => t.CodeCD).HasColumnName("CodeCD");
        this.Property(t => t.Group).HasColumnName("Group");
        this.Property(t => t.Name).HasColumnName("Name");
        this.Property(t => t.Value).HasColumnName("Value");
        this.Property(t => t.Sort).HasColumnName("Sort");
        this.Property(t => t.Description).HasColumnName("Description");
        
      }
    }
}
