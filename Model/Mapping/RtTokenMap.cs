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
    public class RtTokenMap : EntityTypeConfiguration<RtToken>
    {
      public RtTokenMap()
      {
        //����
        this.HasKey(t => t.TokenGuid);
        
        //����
        
        this.Property(t => t.ElementID)
            .HasMaxLength(50);
        
        //�����еĶ�Ӧ
        this.ToTable("RtToken");
        this.Property(t => t.TokenGuid).HasColumnName("TokenGuid");
        this.Property(t => t.InstanceGuid).HasColumnName("InstanceGuid");
        this.Property(t => t.PreToken).HasColumnName("PreToken");
        this.Property(t => t.ElementID).HasColumnName("ElementID");
        this.Property(t => t.Status).HasColumnName("Status");
        this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");

        //�����ϵ
        this.HasRequired(t => t.InstanceGuid_FK)
            .WithMany(t => t.RtToken_InstanceGuidList)
            .HasForeignKey(d => d.InstanceGuid);
        
      }
    }
}
