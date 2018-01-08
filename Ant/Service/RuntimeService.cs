using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Model;
using Ant.Entity.Bpmx;
using Ant.Entity.Esse;
using Ant.Utility;
using Ant.Enact;
using Ant.Parse;

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
        public Guid NewInstanceByID(Guid processID, Guid workID, string backID=null)
        {
            WfProcess wProcess = db.WfProcesss.Where(o => o.ProcessGuid == processID).FirstOrDefault();
            Guid InstanceGuid = Guid.NewGuid();     
            if (wProcess != null)
            {
                ZProcess zProcess = new ZProcess();
                DateTime now = DateTime.Now;
                WfRepository repo = null;
                repo = db.WfRepositorys.Where(o => (o.ProcessGuid == wProcess.ProcessGuid) && (o.Version == wProcess.MasterVer)).FirstOrDefault();
                Dictionary<string, string> iFormDict = new Dictionary<string, string>();
                Dictionary<string, string> iFieldDict = new Dictionary<string, string>();

                //新建流程实例
                RtInstance instance = new RtInstance();       
                instance.InstanceGuid = InstanceGuid;
                instance.RepoGuid = repo.RepoGuid;
                instance.InstanceTitle = wProcess.ProcessName;
                instance.ProcessXml = repo.BpmContent;
                instance.InstanceStatus = 0;
                instance.Originator = AntApi.Auth.CurrentUser.LoginID;
                instance.StartTime = now;

                //新建表单实例
                List<WfForm> forms = db.WfForms.Where(o => o.MasterGuid == repo.RepoGuid).ToList();
                RtForm rtForm = null;
                foreach (WfForm form in forms) 
                {
                    rtForm = new RtForm();
                    rtForm.FormGuid = Guid.NewGuid();
                    rtForm.MasterGuid = InstanceGuid;
                    rtForm.TaskPage = form.TaskPage;
                    rtForm.Html = form.Html;
                    rtForm.CreateTime = now;
                    db.RtForms.Add(rtForm);
                    //iFormDict.Add(form.FormGuid.ToString(), rtForm.FormGuid.ToString());
                }

                //新建变量实例
                List<WfField> fields = db.WfFields.Where(o => o.MasterGuid == repo.RepoGuid).ToList();
                RtField rtField = null;
                foreach (WfField field in fields) 
                {
                    rtField = new RtField();
                    rtField.FieldGuid = Guid.NewGuid();
                    rtField.MasterGuid = InstanceGuid;
                    rtField.Name = field.Name;
                    rtField.Type = field.Type;
                    //rtField.Format = field.;
                    rtField.Value = field.Value;
                    db.RtFields.Add(rtField);
                    //iFieldDict.Add(field.FieldGuid.ToString(), rtField.FieldGuid.ToString());
                }

                //改写流程实例的表单和变量实例


                db.RtInstances.Add(instance);
                db.SaveChanges();

                Context.InstanceID = instance.InstanceGuid;
                Context.ProcessXml = StreamUtil.StreamFromString(repo.BpmContent);

                enact.Start(Context);
            }
            return InstanceGuid;
        }

        /// <summary>
        /// 提交表单，转交下一步
        /// </summary>
        /// <param name="InstanceGuid"></param>
        /// <param name="TaskGuid"></param>
        public void Next(Guid InstanceGuid, Guid TaskGuid) 
        {
            AntApi.Enactor.Next(InstanceGuid, TaskGuid);
        }

        /// <summary>
        /// 给变量赋值
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void SetValue(string name, string value) 
        {
            //RtParam var = new RtParam();
            //var.ParamGuid = Guid.NewGuid();
            //var.InstanceGuid = Context.InstanceID;
            //var.Name = name;
            //var.Value = value;
            //db.RtParams.Add(var);
            //db.SaveChanges();
        }

        /// <summary>
        /// 取变量值
        /// </summary>
        /// <param name="name"></param>
        public string GetValue(string name)
        {
            //RtParam var = db.RtParams.Where(o => o.InstanceGuid == Context.InstanceID && o.Name == name).FirstOrDefault();
            //string value = var.Value;
            //return value;
            return "";
        }

        /// <summary>
        /// 取流程定义中的所有变量定义
        /// </summary>
        /// <param name="processGuid"></param>
        public string GetProcessAllFields(Guid processGuid)
        {
            WfProcess process = db.WfProcesss.First(o => o.ProcessGuid == processGuid);
            WfRepository repo = db.WfRepositorys.First(o => o.RepoGuid == process.ProcessGuid && o.Version == process.MasterVer);
            FlowObjParser fParser = new FlowObjParser();
            List<ZParam> paramList = fParser.FindAllParams(StreamUtil.StreamFromString(repo.BpmContent));
            return JsonConvert.SerializeObject(paramList);
        }

        /// <summary>
        /// 取流程实例中的所有变量定义
        /// </summary>
        /// <param name="instanceGuid"></param>
        public string GetInstanceAllFields(Guid instanceGuid)
        {
            RtInstance instance = db.RtInstances.First(o => o.InstanceGuid == instanceGuid);
            FlowObjParser fParser = new FlowObjParser();
            List<ZParam> paramList = new List<ZParam>(); // fParser.FindAllParams(instance.ProcessXml);
            return JsonConvert.SerializeObject(paramList);
        }
        #endregion

        #region Pravite


        #endregion
    }
}
