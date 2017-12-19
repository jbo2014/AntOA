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
    public class WfDelegateMap : EntityTypeConfiguration<WfDelegate>
    {
      public WfDelegateMap()
      {
        //主键
        this.HasKey(t => t.DelegateGuid);
        
        //属性
        
        //表与列的对应
        this.ToTable("WfDelegate");
        this.Property(t => t.DelegateGuid).HasColumnName("DelegateGuid");
        this.Property(t => t.PrincipalGuid).HasColumnName("PrincipalGuid");
        this.Property(t => t.TrusteeGuid).HasColumnName("TrusteeGuid");
        this.Property(t => t.DelegateType).HasColumnName("DelegateType");
        this.Property(t => t.ObjectGuids).HasColumnName("ObjectGuids");
        this.Property(t => t.Status).HasColumnName("Status");
        this.Property(t => t.EffectTime).HasColumnName("EffectTime");
        this.Property(t => t.ExpireTime).HasColumnName("ExpireTime");
        
      }
    }
}
