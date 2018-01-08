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
    public class RtTransitionMap : EntityTypeConfiguration<RtTransition>
    {
      public RtTransitionMap()
      {
        //����
        this.HasKey(t => t.TransferGuid);
        
        //����
        
        //�����еĶ�Ӧ
        this.ToTable("RtTransition");
        this.Property(t => t.TransferGuid).HasColumnName("TransferGuid");
        this.Property(t => t.InstanceGuid).HasColumnName("InstanceGuid");
        this.Property(t => t.Condition).HasColumnName("Condition");
        this.Property(t => t.ConditionResult).HasColumnName("ConditionResult");
        this.Property(t => t.SourceGuid).HasColumnName("SourceGuid");
        this.Property(t => t.TargetGuid).HasColumnName("TargetGuid");
        
         //�����ϵ
        this.HasRequired(t => t.InstanceGuid_FK)
            .WithMany(t => t.RtTransition_InstanceGuidList)
            .HasForeignKey(d => d.InstanceGuid);
      }
    }
}
