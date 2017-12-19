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
    public class WfNodeMap : EntityTypeConfiguration<WfNode>
    {
      public WfNodeMap()
      {
        //主键
        this.HasKey(t => t.NodeGuid);
        
        //属性
        
        this.Property(t => t.StepDefID)
            .HasMaxLength(10);
        
        //表与列的对应
        this.ToTable("WfNode");
        this.Property(t => t.NodeGuid).HasColumnName("NodeGuid");
        this.Property(t => t.InstanceGuid).HasColumnName("InstanceGuid");
        this.Property(t => t.StepDefID).HasColumnName("StepDefID");
        this.Property(t => t.NodeType).HasColumnName("NodeType");
        this.Property(t => t.RawNodeGuid).HasColumnName("RawNodeGuid");
        this.Property(t => t.Sponsor).HasColumnName("Sponsor");
        this.Property(t => t.PassRate).HasColumnName("PassRate");
        this.Property(t => t.AddSign).HasColumnName("AddSign");
        this.Property(t => t.StartTime).HasColumnName("StartTime");
        this.Property(t => t.EndTime).HasColumnName("EndTime");
        
         //外键关系
        this.HasRequired(t => t.InstanceGuid_FK)
            .WithMany(t => t.WfNode_InstanceGuidList)
            .HasForeignKey(d => d.InstanceGuid);
      }
    }
}
