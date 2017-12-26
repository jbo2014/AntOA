using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Mapping
{
    /// <summary>
    /// 文件说明: 信息实体映射
    /// 作    者: WJB
    /// 生成日期: 2017年12月26日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class FmDataMap : EntityTypeConfiguration<FmData>
    {
      public FmDataMap()
      {
        //主键
        this.HasKey(t => t.FormGuid);
        
        //属性
        
        this.Property(t => t.FormID)
            .HasMaxLength(50);
        
        this.Property(t => t.WidgetID)
            .HasMaxLength(50);
        
        this.Property(t => t.Value)
            .HasMaxLength(255);
        
        //表与列的对应
        this.ToTable("FmData");
        this.Property(t => t.FormGuid).HasColumnName("FormGuid");
        this.Property(t => t.FormID).HasColumnName("FormID");
        this.Property(t => t.WidgetID).HasColumnName("WidgetID");
        this.Property(t => t.Value).HasColumnName("Value");
        
      }
    }
}
