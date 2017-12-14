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
    public class WfVarMap : EntityTypeConfiguration<WfVar>
    {
      public WfVarMap()
      {        
        //����
        		this.HasKey(t => t.ParamGuid);		this.Property(t => t.ParamName).HasMaxLength(100);
        
        //�����еĶ�Ӧ
        this.ToTable("WfVar");
        		this.Property(t => t.ParamGuid).HasColumnName("ParamGuid");		this.Property(t => t.InstanceGuid).HasColumnName("InstanceGuid");		this.Property(t => t.ParamName).HasColumnName("ParamName");		this.Property(t => t.Value).HasColumnName("Value");
        
        //�����ϵ
        		this.HasOptional(t => t.InstanceGuid_FK).WithMany(t => t.WfVar_InstanceGuidList).HasForeignKey(d => d.InstanceGuid);
      }
    }
}
