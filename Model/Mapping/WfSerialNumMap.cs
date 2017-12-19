using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ��Ϣʵ��ӳ��
    /// ��    ��: WJB
    /// ��������: 2017��12��18��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class WfSerialNumMap : EntityTypeConfiguration<WfSerialNum>
    {
      public WfSerialNumMap()
      {
        //����
        this.HasKey(t => t.SerialGuid);
        
        //����
        
        this.Property(t => t.SerialName)
            .HasMaxLength(50);
        
        this.Property(t => t.Filler)
            .HasMaxLength(100);
        
        //�����еĶ�Ӧ
        this.ToTable("WfSerialNum");
        this.Property(t => t.SerialGuid).HasColumnName("SerialGuid");
        this.Property(t => t.SerialName).HasColumnName("SerialName");
        this.Property(t => t.CurrentNum).HasColumnName("CurrentNum");
        this.Property(t => t.Step).HasColumnName("Step");
        this.Property(t => t.Filler).HasColumnName("Filler");
        this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        
      }
    }
}
