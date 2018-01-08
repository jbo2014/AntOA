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
    public class RtDelegateMap : EntityTypeConfiguration<RtDelegate>
    {
      public RtDelegateMap()
      {
        //����
        this.HasKey(t => t.DelegateGuid);
        
        //����
        
        //�����еĶ�Ӧ
        this.ToTable("RtDelegate");
        this.Property(t => t.DelegateGuid).HasColumnName("DelegateGuid");
        this.Property(t => t.PrincipalGuid).HasColumnName("PrincipalGuid");
        this.Property(t => t.TrusteeGuid).HasColumnName("TrusteeGuid");
        this.Property(t => t.DelegateType).HasColumnName("DelegateType");
        this.Property(t => t.ObjectGuids).HasColumnName("ObjectGuids");
        this.Property(t => t.Status).HasColumnName("Status");
        this.Property(t => t.EffectTime).HasColumnName("EffectTime");
        this.Property(t => t.ExpireTime).HasColumnName("ExpireTime");
        
      }
    }
}
