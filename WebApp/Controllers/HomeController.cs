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
            //Ant.Parse.Parser parser = new Ant.Parse.Parser();
            //FileStream stream = new FileStream(@"E:/GitHubs/AntOA/WebApp/Bpmx/xxxx.bpmx", FileMode.Open, FileAccess.Read, FileShare.Read);
            //parser.FindRightNode(stream, "sequence_0004");
            //stream.Close();
            return View();
        }

        [HttpPost]

        public ActionResult Index(FormCollection form) 
        {
            AntApi.Auth.CurrentUser.LoginID = form["uid"];
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

            //// 任务列表
            //TaskService task = ant.GetTaskService();
            //List<Task> tasks = task.TaskListAssignee(Session["uid"]);
            //ViewBag.Tasks = tasks;
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
            if (isNew)
            {
                runtime.StartInstanceByXml(@"E:/GitHubs/AntOA/WebApp/Bpmx/xxx.bpmx");
            }
            else
            {
                runtime.OpenInstance(new Guid(id));
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
            //RuntimeService runtime = ant.RuntimeService();

            ////发起流程
            //runtime.Start(form["InstanceId"]);

            ////正常转交下一步
            //runtime.GoNext();

            ////回退上一步
            //runtime.GoBack();
            return new JsonResult();
        }
    }
}