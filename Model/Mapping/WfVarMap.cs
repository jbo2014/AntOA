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
    public class WfVarMap : EntityTypeConfiguration<WfVar>
    {
      public WfVarMap()
      {
        //主键
        this.HasKey(t => t.ParamGuid);
        
        //属性
        
        this.Property(t => t.ParamName)
            .HasMaxLength(100);
        
        //表与列的对应
        this.ToTable("WfVar");
        this.Property(t => t.ParamGuid).HasColumnName("ParamGuid");
        this.Property(t => t.InstanceGuid).HasColumnName("InstanceGuid");
        this.Property(t => t.ParamName).HasColumnName("ParamName");
        this.Property(t => t.Value).HasColumnName("Value");
        
         //外键关系
        this.HasRequired(t => t.InstanceGuid_FK)
            .WithMany(t => t.WfVar_InstanceGuidList)
            .HasForeignKey(d => d.InstanceGuid);
      }
    }
}
