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
    public class WfSerialNumMap : EntityTypeConfiguration<WfSerialNum>
    {
      public WfSerialNumMap()
      {
        //主键
        this.HasKey(t => t.SerialGuid);
        
        //属性
        
        this.Property(t => t.SerialName)
            .HasMaxLength(50);
        
        this.Property(t => t.Filler)
            .HasMaxLength(100);
        
        //表与列的对应
        this.ToTable("WfSerialNum");
        this.Property(t => t.SerialGuid).HasColumnName("SerialGuid");
        this.Property(t => t.SerialName).HasColumnName("SerialName");
        this.Property(t => t.CurrentNum).HasColumnName("CurrentNum");
        this.Property(t => t.Step).HasColumnName("Step");
        this.Property(t => t.Filler).HasColumnName("Filler");
        this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        
      }
    }
}
