using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ʱ�����ݴ洢��Ϣʵ��ӳ��
    /// ��    ��: JBO
    /// ��������: 2017��12��30��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class DtFieldDatetimeMap : EntityTypeConfiguration<DtFieldDatetime>
    {
      public DtFieldDatetimeMap()
      {
        //����
        this.HasKey(t => t.ColumnGuid);
        
        //����
        
        this.Property(t => t.Name)
            .HasMaxLength(50);
        
        this.Property(t => t.Description)
            .HasMaxLength(100);
        
        this.Property(t => t.Format)
            .HasMaxLength(50);
        
        //�����еĶ�Ӧ
        this.ToTable("DtFieldDatetime");
        this.Property(t => t.ColumnGuid).HasColumnName("ColumnGuid");
        this.Property(t => t.InstanceGuid).HasColumnName("InstanceGuid");
        this.Property(t => t.Name).HasColumnName("Name");
        this.Property(t => t.Value).HasColumnName("Value");
        this.Property(t => t.Description).HasColumnName("Description");
        this.Property(t => t.Format).HasColumnName("Format");
        
      }
    }
}