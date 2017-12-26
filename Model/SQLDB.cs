using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Model.Mapping;
   
namespace Model
{
    /// <summary>
    /// 模块名称: Oracle连接文件
    /// 作    者: WJB
    /// 生成日期: 2017年12月26日
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
       }
       
       public DbSet<FmData> FmDatas { get; set; }
       public DbSet<SysDepartment> SysDepartments { get; set; }
       public DbSet<SysDeptUser> SysDeptUsers { get; set; }
       public DbSet<SysRole> SysRoles { get; set; }
       public DbSet<SysRoleUser> SysRoleUsers { get; set; }
       public DbSet<SysUser> SysUsers { get; set; }
       public DbSet<WfDelegate> WfDelegates { get; set; }
       public DbSet<WfInstance> WfInstances { get; set; }
       public DbSet<WfNode> WfNodes { get; set; }
       public DbSet<WfProcess> WfProcesss { get; set; }
       public DbSet<WfRepository> WfRepositorys { get; set; }
       public DbSet<WfSerialNum> WfSerialNums { get; set; }
       public DbSet<WfTask> WfTasks { get; set; }
       public DbSet<WfToken> WfTokens { get; set; }
       public DbSet<WfTransition> WfTransitions { get; set; }
       public DbSet<WfVar> WfVars { get; set; }
       
       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           modelBuilder.Configurations.Add(new FmDataMap());
           modelBuilder.Configurations.Add(new SysDepartmentMap());
           modelBuilder.Configurations.Add(new SysDeptUserMap());
           modelBuilder.Configurations.Add(new SysRoleMap());
           modelBuilder.Configurations.Add(new SysRoleUserMap());
           modelBuilder.Configurations.Add(new SysUserMap());
           modelBuilder.Configurations.Add(new WfDelegateMap());
           modelBuilder.Configurations.Add(new WfInstanceMap());
           modelBuilder.Configurations.Add(new WfNodeMap());
           modelBuilder.Configurations.Add(new WfProcessMap());
           modelBuilder.Configurations.Add(new WfRepositoryMap());
           modelBuilder.Configurations.Add(new WfSerialNumMap());
           modelBuilder.Configurations.Add(new WfTaskMap());
           modelBuilder.Configurations.Add(new WfTokenMap());
           modelBuilder.Configurations.Add(new WfTransitionMap());
           modelBuilder.Configurations.Add(new WfVarMap());
       }
    }
} 
