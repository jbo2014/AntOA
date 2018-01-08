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
    public class RtTokenMap : EntityTypeConfiguration<RtToken>
    {
      public RtTokenMap()
      {
        //主键
        this.HasKey(t => t.TokenGuid);
        
        //属性
        
        this.Property(t => t.ElementID)
            .HasMaxLength(50);
        
        //表与列的对应
        this.ToTable("RtToken");
        this.Property(t => t.TokenGuid).HasColumnName("TokenGuid");
        this.Property(t => t.InstanceGuid).HasColumnName("InstanceGuid");
        this.Property(t => t.PreToken).HasColumnName("PreToken");
        this.Property(t => t.ElementID).HasColumnName("ElementID");
        this.Property(t => t.Status).HasColumnName("Status");
        this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");

        //外键关系
        this.HasRequired(t => t.InstanceGuid_FK)
            .WithMany(t => t.RtToken_InstanceGuidList)
            .HasForeignKey(d => d.InstanceGuid);
        
      }
    }
}
