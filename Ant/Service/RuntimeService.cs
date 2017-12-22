using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.IO;
using Ant.Entity.Bpmx;
using Ant.Utility;
using Ant.Enact;

namespace Ant.Service
{
    /// <summary>
    /// 运行时服务
    /// </summary>
    public class RuntimeService : BaseService
    {
        EnactService enact;

        /// <summary>
        /// 发起一个新流程
        /// </summary>
        /// <param name="processID">流程定义ID</param>
        /// <param name="workID">业务ID</param>
        /// <param name="backID">子流程返回的栈点ID，非子流程可忽略</param>
        /// <returns></returns>
        public void NewInstanceByID(Guid processID, Guid workID, string backID=null)
        {
            WfProcess wProcess = db.WfProcesss.Where(o => o.ProcessGuid == processID).FirstOrDefault();
            ZProcess zProcess = new ZProcess();
            WfRepository repo = null;

            
            if (wProcess != null)
            {
                repo = db.WfRepositorys.Where(o => (o.ProcessGuid == wProcess.ProcessGuid) && (o.Version == wProcess.MasterVer)).FirstOrDefault();

                enact.Start(StreamUtil.StreamFromString(repo.BpmContent));
            }
        }

        //public ZProcess StartInstanceByXml(string xmlPath)
        //{
        //    ZProcess zProcess = (ZProcess)XmlUtil.LoadFromXml(xmlPath, typeof(ZProcess));
        //    return zProcess;
        //}

        //public ZProcess OpenInstance(Guid instanceId) 
        //{
        //    return new ZProcess();
        //}

        #region Pravite
        /// <summary>
        /// 初始化流程实例
        /// </summary>
        /// <param name="process"></param>
        //private void InitInstance(ZProcess process)
        //{
        //    WfRepository repo = db.WfRepositorys.Where(o => o.ProcessGuid == process.ProcessID && o.Version == process.Version).FirstOrDefault();

        //    WfInstance instance = new WfInstance();
        //    instance.InstanceGuid = Guid.NewGuid();
        //    instance.RepoGuid = repo.RepoGuid;
        //    //instance.InstanceTitle = "";
        //    instance.InstanceStatus = 0;
        //    instance.Originator = AntApi.Auth.CurrentUser.LoginID;
        //    instance.StartTime = DateTime.Now;
        //    db.WfInstances.Add(instance);
        //}
        #endregion
    }
}
