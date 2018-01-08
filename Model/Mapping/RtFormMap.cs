using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ����ʵ����������Ϣʵ��ӳ��
    /// ��    ��: JBO
    /// ��������: 2017��12��30��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class RtFormMap : EntityTypeConfiguration<RtForm>
    {
      public RtFormMap()
      {
        //����
        this.HasKey(t => t.FormGuid);
        
        //����
        
        //�����еĶ�Ӧ
        this.ToTable("RtForm");
        this.Property(t => t.FormGuid).HasColumnName("FormGuid");
        this.Property(t => t.MasterGuid).HasColumnName("MasterGuid");
        this.Property(t => t.Html).HasColumnName("Html");
        this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        this.Property(t => t.CreateUser).HasColumnName("CreateUser");
        this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        this.Property(t => t.UpdateUser).HasColumnName("UpdateUser");
        this.Property(t => t.Released).HasColumnName("Released");

        //�����ϵ
        this.HasRequired(t => t.MasterGuid_FK)
            .WithMany(t => t.RtForm_InstanceGuidList)
            .HasForeignKey(d => d.MasterGuid);
      }
    }
}
