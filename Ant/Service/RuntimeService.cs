using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Model;
using Ant.Entity.Bpmx;
using Ant.Entity.Esse;
using Ant.Utility;
using Ant.Enact;

namespace Ant.Service
{
    /// <summary>
    /// 运行时服务
    /// </summary>
    public class RuntimeService : BaseService
    {
        EnactService enact = new EnactService();

        # region 运行时方法
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
            WfInstance instance = new WfInstance();
            
            if (wProcess != null)
            {
                repo = db.WfRepositorys.Where(o => (o.ProcessGuid == wProcess.ProcessGuid) && (o.Version == wProcess.MasterVer)).FirstOrDefault();

                instance.InstanceGuid = Guid.NewGuid();
                instance.RepoGuid = repo.RepoGuid;
                //instance.InstanceTitle = "";
                instance.InstanceStatus = 0;
                instance.Originator = AntApi.Auth.CurrentUser.LoginID;
                instance.StartTime = DateTime.Now;
                db.WfInstances.Add(instance);

                Context.InstanceID = instance.InstanceGuid;
                Context.ProcessXml = StreamUtil.StreamFromString(repo.BpmContent);

                enact.Start(Context);
            }
        }

        public void OpenTask

        /// <summary>
        /// 提交表单，转交下一步
        /// </summary>
        /// <param name="InstanceGuid"></param>
        /// <param name="TaskGuid"></param>
        public void Next(Guid InstanceGuid, Guid TaskGuid) 
        {
            AntApi.Former.Submit();
            AntApi.Enactor.Next(InstanceGuid, TaskGuid);
        }

        /// <summary>
        /// 给变量赋值
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void SetValue(string name, string value) 
        {
            WfVar var = new WfVar();
            var.ParamGuid = Guid.NewGuid();
            var.InstanceGuid = Context.InstanceID;
            var.ParamName = name;
            var.Value = value;
            db.WfVars.Add(var);
        }

        /// <summary>
        /// 取变量值
        /// </summary>
        /// <param name="name"></param>
        public string GetValue(string name)
        {
            WfVar var = db.WfVars.Where(o => o.InstanceGuid == Context.InstanceID && o.ParamName == name).FirstOrDefault();
            string value = var.Value;
            return value;
        }
        #endregion

        #region Pravite


        #endregion
    }
}
