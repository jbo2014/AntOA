using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ��Ϣʵ��ӳ��
    /// ��    ��: ������
    /// ��������: 2017-12-14
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    public class WfTransitionMap : EntityTypeConfiguration<WfTransition>
    {
      public WfTransitionMap()
      {        
        //����
        		this.HasKey(t => t.TransferGuid);
        
        //�����еĶ�Ӧ
        this.ToTable("WfTransition");
        		this.Property(t => t.TransferGuid).HasColumnName("TransferGuid");		this.Property(t => t.InstanceGuid).HasColumnName("InstanceGuid");		this.Property(t => t.TransferType).HasColumnName("TransferType");		this.Property(t => t.ConditionResult).HasColumnName("ConditionResult");		this.Property(t => t.SourceGuid).HasColumnName("SourceGuid");		this.Property(t => t.TargetGuid).HasColumnName("TargetGuid");		this.Property(t => t.Stamp).HasColumnName("Stamp");
        
        //�����ϵ
        		this.HasOptional(t => t.InstanceGuid_FK).WithMany(t => t.WfTransition_InstanceGuidList).HasForeignKey(d => d.InstanceGuid);
      }
    }
}
