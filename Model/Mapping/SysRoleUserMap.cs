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
    public class SysRoleUserMap : EntityTypeConfiguration<SysRoleUser>
    {
      public SysRoleUserMap()
      {
        //主键
        this.HasKey(t => t.RoleUserGuid);
        
        //属性
        
        //表与列的对应
        this.ToTable("SysRoleUser");
        this.Property(t => t.RoleUserGuid).HasColumnName("RoleUserGuid");
        this.Property(t => t.RoleGuid).HasColumnName("RoleGuid");
        this.Property(t => t.UserGuid).HasColumnName("UserGuid");
        
         //外键关系
        this.HasRequired(t => t.RoleGuid_FK)
            .WithMany(t => t.SysRoleUser_RoleGuidList)
            .HasForeignKey(d => d.RoleGuid);
        this.HasRequired(t => t.UserGuid_FK)
            .WithMany(t => t.SysRoleUser_UserGuidList)
            .HasForeignKey(d => d.UserGuid);
      }
    }
}
