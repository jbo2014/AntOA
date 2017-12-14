using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Mapping
{
    /// <summary>
    /// 文件说明: 流程定义表信息实体映射
    /// 作    者: 王俊波
    /// 生成日期: 2017-12-14
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    public class WfProcessMap : EntityTypeConfiguration<WfProcess>
    {
      public WfProcessMap()
      {        
        //属性
        		this.HasKey(t => t.ProcessGuid);		this.Property(t => t.ProcessName).HasMaxLength(50);		this.Property(t => t.MasterVer).HasMaxLength(10);
        
        //表与列的对应
        this.ToTable("WfProcess");
        		this.Property(t => t.ProcessGuid).HasColumnName("ProcessGuid");		this.Property(t => t.ProcessName).HasColumnName("ProcessName");		this.Property(t => t.MasterVer).HasColumnName("MasterVer");		this.Property(t => t.CreateTime).HasColumnName("CreateTime");		this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");		this.Property(t => t.Stamp).HasColumnName("Stamp");		this.Property(t => t.Status).HasColumnName("Status");
        
        //外键关系
        
      }
    }
}
