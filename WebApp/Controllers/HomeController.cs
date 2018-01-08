using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Newtonsoft.Json;
using Ant;
using Ant.Utility;
using Ant.Service;
using Model;
using Model.ViewModel;
using WebApp.Utility;

namespace WebApp.Controllers
{
    public class HomeController : BaseController
    {
        /// <summary>
        /// 登陆页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            //Ant.Parse.FlowObjParser parser = new Ant.Parse.FlowObjParser();
            //FileStream stream = new FileStream(@"E:/GitHubs/AntOA/WebApp/Bpmx/xxxx.bpmx", FileMode.Open, FileAccess.Read, FileShare.Read);
            ////parser.FindRightNode(stream, "sequence_0004");
            ////parser.FindStartNode(stream);

            //AntApi.Enactor.Start(stream);
            //stream.Close();
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection form) 
        {
            AntApi.Auth.CurrentUser.LoginID = form["uid"];
            AntApi.Auth.CurrentUser.Role = new List<string>();
            AntApi.Auth.CurrentUser.Role.Add(form["rol"]);


            SessionUtil.Remove("UID");
            SessionUtil.Remove("PWD");
            SessionUtil.Remove("Role");
            SessionUtil.Add("UID", form["uid"]);
            SessionUtil.Add("PWD", form["pwd"]);
            SessionUtil.Add("Role", form["rol"]);
            Response.Redirect("/Home/List");
            return View();
        }

        /// <summary>
        /// 流程列表 与 任务列表
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            // 流程定义列表
            ProcessService process = AntApi.Process;
            List<WfProcess> processes = process.GetProcessList();
            ViewBag.Processes = processes;

            // 任务列表
            TaskService task = AntApi.Tasker;
            List<TaskVM> tasks = task.GetTaskListByUser(SessionUtil.Get("UID").ToString());
            ViewBag.Tasks = tasks;
            return View();
        }

        /// <summary>
        /// 流程处理页面：显示
        /// isNew:true 新建，false 待办
        /// </summary>
        /// <returns></returns>
        public ActionResult Handle(bool isNew, string id) 
        {
            RuntimeService runtime = AntApi.Runtime;
            TaskService tasker = AntApi.Tasker;
            FormService former = AntApi.Former;
            RtTask task = null;
            string step = string.Empty;
            Guid instanceGuid = new Guid();
            if (isNew)
            {
                instanceGuid = runtime.NewInstanceByID(new Guid(id), Guid.Empty, null);
                step = "0008";
                task = tasker.GetFirstTaskByInstance(instanceGuid);
            }
            else 
            {
                RtInstance instance = tasker.GetInstanceByTask(new Guid(id));
                instanceGuid = instance.InstanceGuid;
                task = tasker.GetTaskByTaskGuid(new Guid(id));
            }

            ViewBag.FormHtml = former.GetFormByTaskGuid(task.TaskGuid);
            ViewBag.Step = step;
            ViewBag.InstanceGuid = instanceGuid;
            ViewBag.TaskGuid = task.TaskGuid;
            
            return View();
        }

        /// <summary>
        /// 流程处理页面：处理
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Handle(FormCollection form)
        {
            JsonResult jResult = new JsonResult();
            bool bol = false;
            try
            {
                FormService former = AntApi.Former;
                Dictionary<string, object> fieldDict = new Dictionary<string, object>();
                foreach (string key in form.Keys)
                {
                    fieldDict.Add(key, form[key]);
                }
                //TryUpdateModel<Dictionary<string, object>>(fieldDict, form);
                former.SubmitFormData(new Guid(form["InstanceGuid"]), fieldDict);

                RuntimeService run = AntApi.Runtime;
                run.Next(new Guid(form["InstanceGuid"]), new Guid(form["TaskGuid"]));
                bol = true;
            }
            catch (Exception e) 
            {

            }

            //Response.Redirect("/Home/List");
            if (bol)
            {
                jResult.Data = new { Code = "200", Message = "保存成功" };
            }
            else { jResult.Data = new { Code = "400", Message = "保存失败" }; }
            return jResult;
        }

        /// <summary>
        /// 获取表达控件绑定的变量值
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult GetFieldsData(Guid instanceGuid, string fields)
        {
            JsonResult jResult = new JsonResult();
            string data = string.Empty;
            try
            {
                FormService former = AntApi.Former;
                List<string> fieldList = JsonConvert.DeserializeObject<List<string>>(fields);
                Dictionary<string, string> fieldDict = former.GetFieldsDataByFieldList(instanceGuid, fieldList);
                data = JsonConvert.SerializeObject(fieldDict);

                jResult.Data = new { Code = "200", Data = data };
            }
            catch (Exception e)
            {
                jResult.Data = new { Code = "400", Data = data };                
            }

            return jResult;
        }
    }
}