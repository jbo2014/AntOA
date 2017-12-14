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
    public class WfDelegateMap : EntityTypeConfiguration<WfDelegate>
    {
      public WfDelegateMap()
      {        
        //属性
        		this.HasKey(t => t.DelegateGuid);
        
        //表与列的对应
        this.ToTable("WfDelegate");
        		this.Property(t => t.DelegateGuid).HasColumnName("DelegateGuid");		this.Property(t => t.PrincipalGuid).HasColumnName("PrincipalGuid");		this.Property(t => t.TrusteeGuid).HasColumnName("TrusteeGuid");		this.Property(t => t.DelegateType).HasColumnName("DelegateType");		this.Property(t => t.ObjectGuids).HasColumnName("ObjectGuids");		this.Property(t => t.Status).HasColumnName("Status");		this.Property(t => t.EffectTime).HasColumnName("EffectTime");		this.Property(t => t.ExpireTime).HasColumnName("ExpireTime");
        
        //外键关系
        
      }
    }
}
