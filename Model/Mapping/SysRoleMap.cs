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
    public class SysRoleMap : EntityTypeConfiguration<SysRole>
    {
      public SysRoleMap()
      {
        //主键
        this.HasKey(t => t.RoleGuid);
        
        //属性
        
        this.Property(t => t.RoleName)
            .HasMaxLength(100);
        
        //表与列的对应
        this.ToTable("SysRole");
        this.Property(t => t.RoleGuid).HasColumnName("RoleGuid");
        this.Property(t => t.RoleName).HasColumnName("RoleName");
        
      }
    }
}
