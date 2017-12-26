using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Ant;
using Ant.Utility;
using Ant.Service;
using Model;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        AntApi ant = new AntApi();

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
            List<WfTask> tasks = task.GetTaskListByUser(AntApi.Auth.CurrentUser.LoginID);
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
            if (isNew)
            {
                Guid InstanceGuid = runtime.NewInstanceByID(new Guid(id), Guid.Empty, null);
                ViewBag.Step = "0008";
                ViewBag.InstanceGuid = InstanceGuid;
                WfTask task = tasker.GetTaskByInstance(InstanceGuid);
                ViewBag.TaskGuid = task.TaskGuid;
            }
            else 
            {
                WfInstance instance = tasker.GetInstanceByTask(new Guid(id));
                ViewBag.Step = tasker.GetTaskForm(new Guid(id));
                ViewBag.InstanceGuid = instance.InstanceGuid;
                ViewBag.TaskGuid = new Guid(id);
            }           
            
            return View();
        }

        /// <summary>
        /// 流程处理页面：处理
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Handle(FormCollection form)
        {
            FormService former = AntApi.Former;
            former.SaveData(form["step"], form[form["step"]]);

            RuntimeService run = AntApi.Runtime;
            run.Next(new Guid(form["InstanceGuid"]), new Guid(form["TaskGuid"]));

            Response.Redirect("/Home/List");
            return View();
        }
    }
}