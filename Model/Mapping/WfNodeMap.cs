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
    public class WfNodeMap : EntityTypeConfiguration<WfNode>
    {
      public WfNodeMap()
      {        
        //����
        		this.HasKey(t => t.NodeGuid);		this.Property(t => t.StepDefID).HasMaxLength(10);
        
        //�����еĶ�Ӧ
        this.ToTable("WfNode");
        		this.Property(t => t.NodeGuid).HasColumnName("NodeGuid");		this.Property(t => t.InstanceGuid).HasColumnName("InstanceGuid");		this.Property(t => t.StepDefID).HasColumnName("StepDefID");		this.Property(t => t.NodeType).HasColumnName("NodeType");		this.Property(t => t.RawNodeGuid).HasColumnName("RawNodeGuid");		this.Property(t => t.Sponsor).HasColumnName("Sponsor");		this.Property(t => t.PassRate).HasColumnName("PassRate");		this.Property(t => t.AddSign).HasColumnName("AddSign");		this.Property(t => t.StartTime).HasColumnName("StartTime");		this.Property(t => t.EndTime).HasColumnName("EndTime");
        
        //�����ϵ
        		this.HasOptional(t => t.InstanceGuid_FK).WithMany(t => t.WfNode_InstanceGuidList).HasForeignKey(d => d.InstanceGuid);
      }
    }
}
