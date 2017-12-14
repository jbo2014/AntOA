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
    public class WfVarMap : EntityTypeConfiguration<WfVar>
    {
      public WfVarMap()
      {        
        //属性
        		this.HasKey(t => t.ParamGuid);		this.Property(t => t.ParamName).HasMaxLength(100);
        
        //表与列的对应
        this.ToTable("WfVar");
        		this.Property(t => t.ParamGuid).HasColumnName("ParamGuid");		this.Property(t => t.InstanceGuid).HasColumnName("InstanceGuid");		this.Property(t => t.ParamName).HasColumnName("ParamName");		this.Property(t => t.Value).HasColumnName("Value");
        
        //外键关系
        		this.HasOptional(t => t.InstanceGuid_FK).WithMany(t => t.WfVar_InstanceGuidList).HasForeignKey(d => d.InstanceGuid);
      }
    }
}
