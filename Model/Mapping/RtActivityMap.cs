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
    public class RtActivityMap : EntityTypeConfiguration<RtActivity>
    {
      public RtActivityMap()
      {
        //主键
        this.HasKey(t => t.ActivityGuid);
        
        //属性
        
        this.Property(t => t.ActivityID)
            .HasMaxLength(10);
        
        //表与列的对应
        this.ToTable("RtNode");
        this.Property(t => t.ActivityGuid).HasColumnName("ActivityGuid");
        this.Property(t => t.InstanceGuid).HasColumnName("InstanceGuid");
        this.Property(t => t.ActivityID).HasColumnName("ActivityID");
        this.Property(t => t.ActivityType).HasColumnName("ActivityType");
        this.Property(t => t.RawNodeGuid).HasColumnName("RawNodeGuid");
        this.Property(t => t.Sponsor).HasColumnName("Sponsor");
        this.Property(t => t.PassRate).HasColumnName("PassRate");
        this.Property(t => t.AddSign).HasColumnName("AddSign");
        this.Property(t => t.TokensRequired).HasColumnName("TokensRequired");
        this.Property(t => t.TokensHad).HasColumnName("TokensHad");
        this.Property(t => t.FormGuid).HasColumnName("FormGuid");
        this.Property(t => t.StartTime).HasColumnName("StartTime");
        this.Property(t => t.EndTime).HasColumnName("EndTime");
        
         //外键关系
        this.HasRequired(t => t.InstanceGuid_FK)
            .WithMany(t => t.RtActivity_InstanceGuidList)
            .HasForeignKey(d => d.InstanceGuid);
      }
    }
}
