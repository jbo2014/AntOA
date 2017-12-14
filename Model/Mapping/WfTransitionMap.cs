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
    public class WfTransitionMap : EntityTypeConfiguration<WfTransition>
    {
      public WfTransitionMap()
      {        
        //属性
        		this.HasKey(t => t.TransferGuid);
        
        //表与列的对应
        this.ToTable("WfTransition");
        		this.Property(t => t.TransferGuid).HasColumnName("TransferGuid");		this.Property(t => t.InstanceGuid).HasColumnName("InstanceGuid");		this.Property(t => t.TransferType).HasColumnName("TransferType");		this.Property(t => t.ConditionResult).HasColumnName("ConditionResult");		this.Property(t => t.SourceGuid).HasColumnName("SourceGuid");		this.Property(t => t.TargetGuid).HasColumnName("TargetGuid");		this.Property(t => t.Stamp).HasColumnName("Stamp");
        
        //外键关系
        		this.HasOptional(t => t.InstanceGuid_FK).WithMany(t => t.WfTransition_InstanceGuidList).HasForeignKey(d => d.InstanceGuid);
      }
    }
}
