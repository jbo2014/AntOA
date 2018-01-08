using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ��Ϣʵ��ӳ��
    /// ��    ��: JBO
    /// ��������: 2017��12��30��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class RtFieldMap : EntityTypeConfiguration<RtField>
    {
      public RtFieldMap()
        {
            //����
            this.HasKey(t => t.FieldGuid);

            //����

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

            //�����еĶ�Ӧ
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

            //�����ϵ
            this.HasRequired(t => t.MasterGuid_FK)
                .WithMany(t => t.RtField_InstanceGuidList)
                .HasForeignKey(d => d.MasterGuid);
        
      }
    }
}
