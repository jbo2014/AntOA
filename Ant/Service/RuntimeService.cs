using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Ant.Entity.Xpdl;
using Ant.Utility;

namespace Ant.Service
{
    /// <summary>
    /// 运行时服务
    /// </summary>
    public class RuntimeService : BaseService
    {
        /// <summary>
        /// 发起一个新流程
        /// </summary>
        public ZProcess StartInstance(Guid processId)
        {
            SQLDB db = new SQLDB();
            WfProcess wProcess = db.WfProcesss.Where(o => o.ProcessGuid == processId).FirstOrDefault();
            ZProcess zProcess = new ZProcess();
            WfRepository repo = null;
            if (wProcess != null)
            {
                repo = db.WfRepositorys.Where(o => (o.ProcessGuid == wProcess.ProcessGuid) && (o.Version == wProcess.MasterVer)).FirstOrDefault();
                zProcess = XmlUtil.Deserialize<ZProcess>(repo.BpmContent);
            }
            return zProcess;
        }

        public ZProcess StartInstanceByXml(string xmlPath)
        {
            ZProcess zProcess = (ZProcess)XmlUtil.LoadFromXml(xmlPath, typeof(ZProcess));
            return zProcess;
        }

        public void InitInstance(ZProcess process) 
        {
            WfRepository repo = db.WfRepositorys.Where(o=>o.ProcessGuid==process.ProcessID && o.Version==process.Version).FirstOrDefault();

            WfInstance instance = new WfInstance();
            instance.InstanceGuid = Guid.NewGuid();
            instance.RepoGuid = repo.RepoGuid;
            //instance.InstanceTitle = "";
            instance.InstanceStatus = 0;
            instance.Originator = AntApi.Auth.CurrentUser.LoginID;
            instance.StartTime = DateTime.Now;
            db.WfInstances.Add(instance);

            //process.
        }

        public ZProcess OpenInstance(Guid instanceId) 
        {
            return new ZProcess();
        }
    }
}
