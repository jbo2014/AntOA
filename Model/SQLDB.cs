using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using Model.Mapping;
   
namespace Model
{
    /// <summary>
    /// 模块名称: Oracle连接文件
    /// 作    者: JBO
    /// 生成日期: 2017年12月30日
    /// 生成模板: CTSR.Template.OracleDAL.SQLDBConnect_01 版
    ///           MVC模式
    /// 特别说明: 本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    public class SQLDB : DbContext
    {
        static SQLDB()
        {
            Database.SetInitializer<SQLDB>(null);
        }

       public SQLDB()
           : base("Name=SQLDB")
       {
           Database.SetInitializer<SQLDB>(new CustomInitializer());
           this.Configuration.LazyLoadingEnabled = false; 
       }
       
       public DbSet<CodeTable> CodeTables { get; set; }
       public DbSet<RtField> RtFields { get; set; }
       public DbSet<RtDelegate> RtDelegates { get; set; }
       public DbSet<RtForm> RtForms { get; set; }
       public DbSet<RtInstance> RtInstances { get; set; }
       public DbSet<RtActivity> RtActivitys { get; set; }
       public DbSet<RtTask> RtTasks { get; set; }
       public DbSet<RtToken> RtTokens { get; set; }
       public DbSet<RtTransition> RtTransitions { get; set; }
       public DbSet<SysDepartment> SysDepartments { get; set; }
       public DbSet<SysDeptUser> SysDeptUsers { get; set; }
       public DbSet<SysRole> SysRoles { get; set; }
       public DbSet<SysRoleUser> SysRoleUsers { get; set; }
       public DbSet<SysUser> SysUsers { get; set; }
       public DbSet<WfForm> WfForms { get; set; }
       public DbSet<WfField> WfFields { get; set; }
       public DbSet<WfProcess> WfProcesss { get; set; }
       public DbSet<WfRepository> WfRepositorys { get; set; }
       
       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {           
           modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

           modelBuilder.Configurations.Add(new CodeTableMap());
           //modelBuilder.Configurations.Add(new DtFieldDatetimeMap());
           //modelBuilder.Configurations.Add(new DtFieldDecimalMap());
           //modelBuilder.Configurations.Add(new DtFieldIntMap());
           //modelBuilder.Configurations.Add(new DtFieldTextMap());
           //modelBuilder.Configurations.Add(new DtFieldVarcharMap());
           //modelBuilder.Configurations.Add(new DtFieldXmlMap());
           modelBuilder.Configurations.Add(new RtDelegateMap());
           modelBuilder.Configurations.Add(new RtFieldMap());
           modelBuilder.Configurations.Add(new RtFormMap());
           modelBuilder.Configurations.Add(new RtInstanceMap());
           modelBuilder.Configurations.Add(new RtActivityMap());
           modelBuilder.Configurations.Add(new RtTaskMap());
           modelBuilder.Configurations.Add(new RtTokenMap());
           modelBuilder.Configurations.Add(new RtTransitionMap());
           modelBuilder.Configurations.Add(new SysDepartmentMap());
           modelBuilder.Configurations.Add(new SysDeptUserMap());
           modelBuilder.Configurations.Add(new SysRoleMap());
           modelBuilder.Configurations.Add(new SysRoleUserMap());
           modelBuilder.Configurations.Add(new SysUserMap());
           modelBuilder.Configurations.Add(new WfFormMap());
           modelBuilder.Configurations.Add(new WfFieldMap());
           modelBuilder.Configurations.Add(new WfProcessMap());
           modelBuilder.Configurations.Add(new WfRepositoryMap());
       }
    }
} 
