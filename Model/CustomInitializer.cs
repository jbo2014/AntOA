using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.IO;

namespace Model
{
    public class CustomInitializer : DropCreateDatabaseIfModelChanges<SQLDB>
    {
        protected override void Seed(SQLDB db)
        {
            for (int i = 0; i < 3; i++)
            {
                SysUser user = new SysUser();
                user.UserGuid = Guid.NewGuid();
                user.UserID = "user"+i.ToString()+i.ToString();
                user.UserPwd = "123";
                user.UserName = "user" + i.ToString() + i.ToString();
                db.SysUsers.Add(user);
            }

            WfProcess p = new WfProcess();
            p.ProcessGuid = Guid.NewGuid();
            p.ProcessName = "请假";
            p.MasterVer = "1";
            p.CreateTime = DateTime.Now;
            db.WfProcesss.Add(p);

            WfRepository repo = new WfRepository();
            repo.RepoGuid = Guid.NewGuid();
            repo.CreateTime = DateTime.Now;
            repo.BpmContent = System.IO.File.ReadAllText(@"E:/GitHubs/AntOA/WebApp/Bpmx/xxxxx.bpmx");
            db.WfRepositorys.Add(repo);

            base.Seed(db);

        }
    }
}
