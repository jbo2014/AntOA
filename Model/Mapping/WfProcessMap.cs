using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Mapping
{
    /// <summary>
    /// 文件说明: 流程定义表信息实体映射
    /// 作    者: JBO
    /// 生成日期: 2017年12月30日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class WfProcessMap : EntityTypeConfiguration<WfProcess>
    {
      public WfProcessMap()
      {
        //主键
        this.HasKey(t => t.ProcessGuid);
        
        //属性
        
        this.Property(t => t.ProcessName)
            .HasMaxLength(50);
        
        this.Property(t => t.MasterVer)
            .HasMaxLength(10);
        
        //表与列的对应
        this.ToTable("WfProcess");
        this.Property(t => t.ProcessGuid).HasColumnName("ProcessGuid");
        this.Property(t => t.ProcessName).HasColumnName("ProcessName");
        this.Property(t => t.MasterVer).HasColumnName("MasterVer");
        this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        this.Property(t => t.Status).HasColumnName("Status");
        
      }
    }
}
