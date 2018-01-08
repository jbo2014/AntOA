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
    public class RtFieldMap : EntityTypeConfiguration<RtField>
    {
      public RtFieldMap()
        {
            //主键
            this.HasKey(t => t.FieldGuid);

            //属性

            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Alias)
                .HasMaxLength(50);

            this.Property(t => t.Type)
                .HasMaxLength(50);

            this.Property(t => t.GroupName)
                .HasMaxLength(50);

            this.Property(t => t.Format)
                .HasMaxLength(50);

            this.Property(t => t.Value)
                .HasMaxLength(255);

            this.Property(t => t.Description)
                .HasMaxLength(255);

            //表与列的对应
            this.ToTable("RtField");
            this.Property(t => t.FieldGuid).HasColumnName("FieldGuid");
            this.Property(t => t.MasterGuid).HasColumnName("MasterGuid");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Alias).HasColumnName("Alias");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.IsArray).HasColumnName("IsArray");
            this.Property(t => t.GroupName).HasColumnName("GroupName");
            this.Property(t => t.Format).HasColumnName("Format");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.Description).HasColumnName("Description");

            //外键关系
            this.HasRequired(t => t.MasterGuid_FK)
                .WithMany(t => t.RtField_InstanceGuidList)
                .HasForeignKey(d => d.MasterGuid);
        
      }
    }
}
