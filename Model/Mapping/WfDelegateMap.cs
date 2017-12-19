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
    public class WfDelegateMap : EntityTypeConfiguration<WfDelegate>
    {
      public WfDelegateMap()
      {
        //����
        this.HasKey(t => t.DelegateGuid);
        
        //����
        
        //�����еĶ�Ӧ
        this.ToTable("WfDelegate");
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
