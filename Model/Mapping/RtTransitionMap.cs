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
    public class RtTransitionMap : EntityTypeConfiguration<RtTransition>
    {
      public RtTransitionMap()
      {
        //主键
        this.HasKey(t => t.TransferGuid);
        
        //属性
        
        //表与列的对应
        this.ToTable("RtTransition");
        this.Property(t => t.TransferGuid).HasColumnName("TransferGuid");
        this.Property(t => t.InstanceGuid).HasColumnName("InstanceGuid");
        this.Property(t => t.Condition).HasColumnName("Condition");
        this.Property(t => t.ConditionResult).HasColumnName("ConditionResult");
        this.Property(t => t.SourceGuid).HasColumnName("SourceGuid");
        this.Property(t => t.TargetGuid).HasColumnName("TargetGuid");
        
         //外键关系
        this.HasRequired(t => t.InstanceGuid_FK)
            .WithMany(t => t.RtTransition_InstanceGuidList)
            .HasForeignKey(d => d.InstanceGuid);
      }
    }
}
