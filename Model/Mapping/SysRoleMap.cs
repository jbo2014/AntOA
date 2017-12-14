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
    public class SysRoleMap : EntityTypeConfiguration<SysRole>
    {
      public SysRoleMap()
      {        
        //属性
        		this.HasKey(t => t.RoleGuid);		this.Property(t => t.RoleName).HasMaxLength(100);
        
        //表与列的对应
        this.ToTable("SysRole");
        		this.Property(t => t.RoleGuid).HasColumnName("RoleGuid");		this.Property(t => t.RoleName).HasColumnName("RoleName");
        
        //外键关系
        
      }
    }
}
