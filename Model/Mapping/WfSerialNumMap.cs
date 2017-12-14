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
    public class WfSerialNumMap : EntityTypeConfiguration<WfSerialNum>
    {
      public WfSerialNumMap()
      {        
        //属性
        		this.HasKey(t => t.SerialGuid);		this.Property(t => t.SerialName).HasMaxLength(50);		this.Property(t => t.Filler).HasMaxLength(100);
        
        //表与列的对应
        this.ToTable("WfSerialNum");
        		this.Property(t => t.SerialGuid).HasColumnName("SerialGuid");		this.Property(t => t.SerialName).HasColumnName("SerialName");		this.Property(t => t.CurrentNum).HasColumnName("CurrentNum");		this.Property(t => t.Step).HasColumnName("Step");		this.Property(t => t.Filler).HasColumnName("Filler");		this.Property(t => t.CreateTime).HasColumnName("CreateTime");		this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        
        //外键关系
        
      }
    }
}
