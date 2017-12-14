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
    public class SysDeptUserMap : EntityTypeConfiguration<SysDeptUser>
    {
      public SysDeptUserMap()
      {        
        //属性
        		this.HasKey(t => t.DeptUserGuid);
        
        //表与列的对应
        this.ToTable("SysDeptUser");
        		this.Property(t => t.DeptUserGuid).HasColumnName("DeptUserGuid");		this.Property(t => t.DeptGuid).HasColumnName("DeptGuid");		this.Property(t => t.UserGuid).HasColumnName("UserGuid");
        
        //外键关系
        		this.HasOptional(t => t.DeptGuid_FK).WithMany(t => t.SysDeptUser_DeptGuidList).HasForeignKey(d => d.DeptGuid);		this.HasOptional(t => t.UserGuid_FK).WithMany(t => t.SysDeptUser_UserGuidList).HasForeignKey(d => d.UserGuid);
      }
    }
}
