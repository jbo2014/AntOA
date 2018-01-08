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
    public class WfFormMap : EntityTypeConfiguration<WfForm>
    {
      public WfFormMap()
      {
        //����
        this.HasKey(t => t.FormGuid);
        
        //����
        
        this.Property(t => t.Type)
            .HasMaxLength(50);
        
        this.Property(t => t.Name)
            .HasMaxLength(100);
        
        //�����еĶ�Ӧ
        this.ToTable("WfForm");
        this.Property(t => t.FormGuid).HasColumnName("FormGuid");
        this.Property(t => t.Type).HasColumnName("Type");
        this.Property(t => t.Html).HasColumnName("Html");
        this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        this.Property(t => t.Name).HasColumnName("Name");
        this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        this.Property(t => t.Released).HasColumnName("Released");

        //�����ϵ
        this.HasRequired(t => t.MasterGuid_FK)
            .WithMany(t => t.WfForm_RepoGuidList)
            .HasForeignKey(d => d.MasterGuid);
        
      }
    }
}
