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
    public class SysDepartmentMap : EntityTypeConfiguration<SysDepartment>
    {
      public SysDepartmentMap()
      {
        //主键
        this.HasKey(t => t.DeptGuid);
        
        //属性
        
        this.Property(t => t.DeptName)
            .HasMaxLength(100);
        
        //表与列的对应
        this.ToTable("SysDepartment");
        this.Property(t => t.DeptGuid).HasColumnName("DeptGuid");
        this.Property(t => t.DeptName).HasColumnName("DeptName");
        this.Property(t => t.HiDeptGuid).HasColumnName("HiDeptGuid");
        this.Property(t => t.DeptLeader).HasColumnName("DeptLeader");
        
      }
    }
}
