using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Mapping
{
    /// <summary>
    /// 文件说明: 小数内容存储信息实体映射
    /// 作    者: JBO
    /// 生成日期: 2017年12月30日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class DtFieldDecimalMap : EntityTypeConfiguration<DtFieldDecimal>
    {
      public DtFieldDecimalMap()
      {
        //主键
        this.HasKey(t => t.ColumnGuid);
        
        //属性
        
        this.Property(t => t.Name)
            .HasMaxLength(50);
        
        this.Property(t => t.Description)
            .HasMaxLength(100);
        
        //表与列的对应
        this.ToTable("DtFieldDecimal");
        this.Property(t => t.ColumnGuid).HasColumnName("ColumnGuid");
        this.Property(t => t.InstanceGuid).HasColumnName("InstanceGuid");
        this.Property(t => t.Name).HasColumnName("Name");
        this.Property(t => t.Value).HasColumnName("Value");
        this.Property(t => t.Description).HasColumnName("Description");
        
      }
    }
}
