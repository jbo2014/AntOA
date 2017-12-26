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
    public class WfTokenMap : EntityTypeConfiguration<WfToken>
    {
      public WfTokenMap()
      {
        //����
        this.HasKey(t => t.TokenGuid);
        
        //����
        
        this.Property(t => t.ElementID)
            .HasMaxLength(50);
        
        //�����еĶ�Ӧ
        this.ToTable("WfToken");
        this.Property(t => t.TokenGuid).HasColumnName("TokenGuid");
        this.Property(t => t.InstanceGuid).HasColumnName("InstanceGuid");
        this.Property(t => t.ParentToken).HasColumnName("ParentToken");
        this.Property(t => t.ElementID).HasColumnName("ElementID");
        this.Property(t => t.Status).HasColumnName("Status");
        this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        
      }
    }
}
