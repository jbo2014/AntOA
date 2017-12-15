using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ant.Entity.BPM;
using Model;

namespace Ant.Service
{
    /// <summary>
    /// 运行时服务
    /// </summary>
    public class RuntimeService
    {
        /// <summary>
        /// 发起一个新流程
        /// </summary>
        public ZProcess StartInstance(Guid processId)
        {
            SQLDB db = new SQLDB();
            WfProcess process = db.WfProcesses.Where(o => o.ProcessGuid == processId).FirstOrDefault();

            ZProcess zProcess = new ZProcess();
            if (process != null)
            {
                WfRepository repo = db.WfRepositories.Where(o => (o.ProcessGuid == process.ProcessGuid) && (o.Version == process.MasterVer)).FirstOrDefault();
                //zProcess = repo.BpmContent;
            }
            return zProcess;
        }
    }
}
