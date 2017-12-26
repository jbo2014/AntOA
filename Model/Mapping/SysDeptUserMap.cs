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
    public class SysDeptUserMap : EntityTypeConfiguration<SysDeptUser>
    {
      public SysDeptUserMap()
      {
        //主键
        this.HasKey(t => t.DeptUserGuid);
        
        //属性
        
        //表与列的对应
        this.ToTable("SysDeptUser");
        this.Property(t => t.DeptUserGuid).HasColumnName("DeptUserGuid");
        this.Property(t => t.DeptGuid).HasColumnName("DeptGuid");
        this.Property(t => t.UserGuid).HasColumnName("UserGuid");
        
         //外键关系
        this.HasRequired(t => t.DeptGuid_FK)
            .WithMany(t => t.SysDeptUser_DeptGuidList)
            .HasForeignKey(d => d.DeptGuid);
        this.HasRequired(t => t.UserGuid_FK)
            .WithMany(t => t.SysDeptUser_UserGuidList)
            .HasForeignKey(d => d.UserGuid);
      }
    }
}
