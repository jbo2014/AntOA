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
    public class SysRoleUserMap : EntityTypeConfiguration<SysRoleUser>
    {
      public SysRoleUserMap()
      {        
        //属性
        		this.HasKey(t => t.RoleUserGuid);
        
        //表与列的对应
        this.ToTable("SysRoleUser");
        		this.Property(t => t.RoleUserGuid).HasColumnName("RoleUserGuid");		this.Property(t => t.RoleGuid).HasColumnName("RoleGuid");		this.Property(t => t.UserGuid).HasColumnName("UserGuid");
        
        //外键关系
        		this.HasOptional(t => t.RoleGuid_FK).WithMany(t => t.SysRoleUser_RoleGuidList).HasForeignKey(d => d.RoleGuid);		this.HasOptional(t => t.UserGuid_FK).WithMany(t => t.SysRoleUser_UserGuidList).HasForeignKey(d => d.UserGuid);
      }
    }
}
