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
    public class WfVarMap : EntityTypeConfiguration<WfVar>
    {
      public WfVarMap()
      {
        //����
        this.HasKey(t => t.ParamGuid);
        
        //����
        
        this.Property(t => t.ParamName)
            .HasMaxLength(100);
        
        //�����еĶ�Ӧ
        this.ToTable("WfVar");
        this.Property(t => t.ParamGuid).HasColumnName("ParamGuid");
        this.Property(t => t.InstanceGuid).HasColumnName("InstanceGuid");
        this.Property(t => t.ParamName).HasColumnName("ParamName");
        this.Property(t => t.Value).HasColumnName("Value");
        
         //�����ϵ
        this.HasRequired(t => t.InstanceGuid_FK)
            .WithMany(t => t.WfVar_InstanceGuidList)
            .HasForeignKey(d => d.InstanceGuid);
      }
    }
}
