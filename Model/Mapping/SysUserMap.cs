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
    public class SysUserMap : EntityTypeConfiguration<SysUser>
    {
      public SysUserMap()
      {        
        //属性
        		this.HasKey(t => t.UserGuid);		this.Property(t => t.UserID).HasMaxLength(50);		this.Property(t => t.UserPwd).HasMaxLength(50);		this.Property(t => t.UserName).HasMaxLength(50);		this.Property(t => t.Phone).HasMaxLength(12);		this.Property(t => t.Email).HasMaxLength(50);
        
        //表与列的对应
        this.ToTable("SysUser");
        		this.Property(t => t.UserGuid).HasColumnName("UserGuid");		this.Property(t => t.UserID).HasColumnName("UserID");		this.Property(t => t.UserPwd).HasColumnName("UserPwd");		this.Property(t => t.UserName).HasColumnName("UserName");		this.Property(t => t.UserSex).HasColumnName("UserSex");		this.Property(t => t.Phone).HasColumnName("Phone");		this.Property(t => t.Email).HasColumnName("Email");
        
        //外键关系
        
      }
    }
}
