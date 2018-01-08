using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Ant.Invoke.Form;

namespace Ant.Service
{
    /// <summary>
    /// 表单服务：启动表单 和 任务表单
    /// </summary>
    public class FormService : BaseService
    {
        public List<WfForm> GetProcessFormList(Guid masterID)
        {
            List<WfForm> forms = db.WfForms.Where(o => o.MasterGuid == masterID).ToList();
            return forms;
        }

        public List<RtForm> GetInstanceFormList(Guid masterID)
        {
            List<RtForm> forms = db.RtForms.Where(o=>o.MasterGuid == masterID).ToList();
            return forms;
        }

        /// <summary>
        /// 获取单个表单（定义/实例）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="isCase"></param>
        /// <param name="masterID"></param>
        /// <param name="formID"></param>
        /// <returns></returns>
        public T GetForm<T>(int isCase, Guid masterID, Guid formID)
        {
            IForm former = null;
            object form = null;
            if(isCase==1)
            {
                former = new CaseForm();
                form = former.GetForm(formID);
            }
            else if (isCase == 0)
            {
                former = new RepoForm();
                form = former.GetForm(formID);
            }
            return (T)form;
        }

        /// <summary>
        /// 保存表单定义数据（流程定义或流程实例）
        /// </summary>
        /// <param name="masterID">InstanceGui的/RepoGuid</param>
        /// <param name="formID"></param>
        /// <param name="value">表单html内容</param>
        /// <returns></returns>
        public bool SaveFormData(bool isCase, Guid masterID, Guid formID, string value)
        {
            if (isCase)
            {
                RtForm form = null;
                if (formID == Guid.Empty)
                {
                    form = new RtForm();
                    form.FormGuid = Guid.NewGuid();
                    form.MasterGuid = masterID;
                    form.Html = value;
                    form.Released = 0;
                    form.CreateTime = DateTime.Now;
                    db.RtForms.Add(form);
                }
                else
                {
                    form = db.RtForms.First(o => o.FormGuid == formID);
                    form.Html = value;
                    form.Released = form.Released + 1;
                    form.UpdateTime = DateTime.Now;
                }
            }
            else
            {
                WfForm form = null;
                if (formID == Guid.Empty)
                {
                    form = new WfForm();
                    form.FormGuid = Guid.NewGuid();
                    form.MasterGuid = masterID;
                    form.Html = value;
                    form.Released = 0;
                    form.CreateTime = DateTime.Now;
                    db.WfForms.Add(form);
                }
                else
                {
                    form = db.WfForms.First(o => o.FormGuid == formID);
                    form.Html = value;
                    form.Released = form.Released + 1;
                    form.UpdateTime = DateTime.Now;
                }
            }
            
            db.SaveChanges();
            return true;
        }

        public string GetFormByTaskGuid(Guid taskGuid) 
        {
            RtTask task = db.RtTasks.First(o=>o.TaskGuid==taskGuid);
            RtActivity activity = db.RtActivitys.First(o=>o.ActivityGuid==task.ActivityGuid);
            RtForm form = db.RtForms.First(o => o.TaskPage == activity.TaskPage && o.MasterGuid == task.InstanceGuid);
            return form.Html;
        }

        /// <summary>
        /// 处理页面的表单提交功能
        /// </summary>
        /// <returns></returns>
        public bool SubmitFormData(Guid instanceGuid, Dictionary<string, object> fieldDict) 
        {
            try
            {
                List<RtField> fields = db.RtFields.Where(o => o.MasterGuid == instanceGuid).ToList();
                foreach (RtField field in fields)
                {
                    if (fieldDict.Keys.Contains(field.Name))
                    {
                        field.Value = fieldDict[field.Name].ToString();
                    }
                }
                db.SaveChanges();
            }
            catch(Exception e)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 获取表单控件绑定的变量值
        /// </summary>
        /// <param name="fieldList">需要获取得变量数组</param>
        /// <returns></returns>
        public Dictionary<string, string> GetFieldsDataByFieldList(Guid instanceGuid, List<string> fieldList) 
        {
            Dictionary<string, string> fieldDict = new Dictionary<string,string>();
            List<RtField> fields = db.RtFields.Where(o => fieldList.Contains(o.Name) && o.MasterGuid == instanceGuid).ToList();
            foreach (RtField field in fields) 
            {
                fieldDict.Add(field.Name, field.Value);
            }
            return fieldDict;
        }
    }
}
