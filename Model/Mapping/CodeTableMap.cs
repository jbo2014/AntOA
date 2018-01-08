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
    public class CodeTableMap : EntityTypeConfiguration<CodeTable>
    {
      public CodeTableMap()
      {
        //����
        this.HasKey(t => t.CodeCD);
        
        //����
        
        this.Property(t => t.Group)
            .HasMaxLength(100);
        
        this.Property(t => t.Name)
            .HasMaxLength(100);
        
        this.Property(t => t.Description)
            .HasMaxLength(50);
        
        //�����еĶ�Ӧ
        this.ToTable("CodeTable");
        this.Property(t => t.CodeCD).HasColumnName("CodeCD");
        this.Property(t => t.Group).HasColumnName("Group");
        this.Property(t => t.Name).HasColumnName("Name");
        this.Property(t => t.Value).HasColumnName("Value");
        this.Property(t => t.Sort).HasColumnName("Sort");
        this.Property(t => t.Description).HasColumnName("Description");
        
      }
    }
}
