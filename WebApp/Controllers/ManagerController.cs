using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ant;
using Model;

namespace WebApp.Controllers
{
    public class ManagerController : BaseController
    {
        public ActionResult Index() 
        {
            return View();
        }

        /// <summary>
        /// 实例List
        /// </summary>
        /// <returns></returns>
        public ActionResult InstanceList()
        {
            ViewBag.InstanceList = AntApi.Manager.GetInstanceList();
            return View();
        }

        /// <summary>
        /// 流程定义List
        /// </summary>
        /// <returns></returns>
        public ActionResult ProcessList()
        {
            ViewBag.ProcessList = AntApi.Manager.GetProcessList();
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isCase">0.定义，1.实例</param>
        /// <param name="id">ProcessGuid/InstanceGuid</param>
        /// <returns></returns>
        public ActionResult FormList(int isCase, Guid id) 
        {
            if (isCase == 1)
            {
                ViewBag.FormList = AntApi.Manager.GetFormList<RtForm>(true, id);
                ViewBag.ID = id;
            }
            else if (isCase == 0)
            {
                WfRepository repo = AntApi.Process.GetMasterRepoByProcess(id);
                ViewBag.FormList = AntApi.Manager.GetFormList<WfForm>(false, repo.RepoGuid);
                ViewBag.ID = repo.RepoGuid;
            }
            ViewBag.IsCase = isCase;
            return View();
        }

    }
}
