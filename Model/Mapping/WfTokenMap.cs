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
    public class WfTokenMap : EntityTypeConfiguration<WfToken>
    {
      public WfTokenMap()
      {
        //主键
        this.HasKey(t => t.TokenGuid);
        
        //属性
        
        this.Property(t => t.ElementID)
            .HasMaxLength(50);
        
        //表与列的对应
        this.ToTable("WfToken");
        this.Property(t => t.TokenGuid).HasColumnName("TokenGuid");
        this.Property(t => t.InstanceGuid).HasColumnName("InstanceGuid");
        this.Property(t => t.ParentToken).HasColumnName("ParentToken");
        this.Property(t => t.ElementID).HasColumnName("ElementID");
        this.Property(t => t.Status).HasColumnName("Status");
        this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        
      }
    }
}
