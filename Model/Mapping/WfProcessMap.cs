using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ���̶������Ϣʵ��ӳ��
    /// ��    ��: JBO
    /// ��������: 2017��12��30��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class WfProcessMap : EntityTypeConfiguration<WfProcess>
    {
      public WfProcessMap()
      {
        //����
        this.HasKey(t => t.ProcessGuid);
        
        //����
        
        this.Property(t => t.ProcessName)
            .HasMaxLength(50);
        
        this.Property(t => t.MasterVer)
            .HasMaxLength(10);
        
        //�����еĶ�Ӧ
        this.ToTable("WfProcess");
        this.Property(t => t.ProcessGuid).HasColumnName("ProcessGuid");
        this.Property(t => t.ProcessName).HasColumnName("ProcessName");
        this.Property(t => t.MasterVer).HasColumnName("MasterVer");
        this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        this.Property(t => t.Status).HasColumnName("Status");
        
      }
    }
}
