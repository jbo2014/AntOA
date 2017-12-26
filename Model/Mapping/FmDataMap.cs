using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ��Ϣʵ��ӳ��
    /// ��    ��: WJB
    /// ��������: 2017��12��26��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class FmDataMap : EntityTypeConfiguration<FmData>
    {
      public FmDataMap()
      {
        //����
        this.HasKey(t => t.FormGuid);
        
        //����
        
        this.Property(t => t.FormID)
            .HasMaxLength(50);
        
        this.Property(t => t.WidgetID)
            .HasMaxLength(50);
        
        this.Property(t => t.Value)
            .HasMaxLength(255);
        
        //�����еĶ�Ӧ
        this.ToTable("FmData");
        this.Property(t => t.FormGuid).HasColumnName("FormGuid");
        this.Property(t => t.FormID).HasColumnName("FormID");
        this.Property(t => t.WidgetID).HasColumnName("WidgetID");
        this.Property(t => t.Value).HasColumnName("Value");
        
      }
    }
}
