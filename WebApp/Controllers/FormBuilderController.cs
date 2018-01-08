using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Model;
using Ant;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class FormBuilderController : BaseController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isCase">0.定义,1.实例</param>
        /// <param name="id">实例或定义的Guid</param>
        /// <param name="formID"></param>
        /// <returns></returns>
        public ActionResult Index(int isCase, string id, string formID = null)
        {
            if (!string.IsNullOrEmpty(formID))
            {
                if (isCase == 1)
                {
                    RtForm form = AntApi.Former.GetForm<RtForm>(isCase, new Guid(id), new Guid(formID));
                    ViewBag.Form = form;
                }
                else if (isCase == 0)
                {
                    WfForm form = AntApi.Former.GetForm<WfForm>(isCase, new Guid(id), new Guid(formID));
                    ViewBag.Form = form;
                }
            }
            else 
            {
                ViewBag.Form = null;
            }
            ViewBag.IsCase = isCase;
            ViewBag.MasterGuid = id;
            return View();
        }

        /// <summary>
        /// 插入控件
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public string Insert() 
        {
            return NewUnixMsec();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isInstance">是否实例，0定义，1实例</param>
        /// <param name="instanceGuid"></param>
        /// <returns></returns>
        [HttpPost]
        public string GetFields(int isInstance, string guid)
        {
            List<Field> fields = new List<Field>();
            string jStr = string.Empty;
            if (isInstance == 0)
                jStr = AntApi.Process.GetAllProcessFieldsByRepoGuid(new Guid(guid));
            return jStr;
        }

        /// <summary>
        /// 保存表单
        /// </summary>
        /// <returns></returns>
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult FormSave(FormCollection form)
        {
            JsonResult jResult = new JsonResult();
            //string html = Server.HtmlEncode(form["FormHtml"]);
            bool isCase = false;
            if(Convert.ToInt32(form["IsCase"])==1)
                isCase = true;
            else if(Convert.ToInt32(form["IsCase"])==0)
                isCase = false;

            Guid FormGuid = new Guid();
            if(!string.IsNullOrEmpty(form["FormGuid"]))
                FormGuid = new Guid(form["FormGuid"]);
            bool bol = AntApi.Former.SaveFormData(isCase, new Guid(form["MasterGuid"]), FormGuid, form["FormHtml"]);
            if (bol) 
            {
                jResult.Data = new { Code="200", Message="保存成功" };
            }
            return jResult;
        }


        #region 私有方法
        /// <summary>
        /// Unix毫秒时间戳
        /// </summary>
        /// <returns></returns>
        private string NewUnixMsec()
        {
            string code = ((DateTime.Now.ToLocalTime().Ticks - 621355968000000000) / 10).ToString("x8");
            return code;
        }
        #endregion
    }
}
