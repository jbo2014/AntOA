using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ant;
using Ant.Service;

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
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection form) 
        {
            Session["uid"] = form["uid"];
            Session["pwd"] = form["pwd"];
            Session["rol"] = form["rol"];
            return View("List");
        }

        /// <summary>
        /// 流程列表 与 任务列表
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            // 流程定义列表
            ProcessService process = ant.GetProcessService();
            List<Process> processes = process.ProcessDefList(Session["rol"]);
            ViewBag.Processes = processes;

            // 任务列表
            TaskService task = ant.GetTaskService();
            List<Task> tasks = task.TaskListAssignee(Session["uid"]);
            ViewBag.Tasks = tasks;
        }

        /// <summary>
        /// 流程处理页面：显示
        /// isNew:true 新建，false 待办
        /// </summary>
        /// <returns></returns>
        public ActionResult Handle(bool isNew, string id) 
        {
            RuntimeService runtime = ant.GetRuntimeService();
            if(isNew)
                runtime.CreateInstance(id);
            else
                runtime.OpenInstance(id);
        }

        /// <summary>
        /// 流程处理页面：处理
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Handle(FormCollection form)
        {
            RuntimeService runtime = ant.RuntimeService();
            
            //发起流程
            runtime.Start(form["InstanceId"]);
            
            //正常转交下一步
            runtime.GoNext();

            //回退上一步
            runtime.GoBack();
        }
    }
}