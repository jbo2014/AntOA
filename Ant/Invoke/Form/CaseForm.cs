using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Ant.Invoke.Form
{
    public class CaseForm : IForm
    {
        /// <summary>
        /// 获取流程实例中的表单
        /// </summary>
        /// <param name="ID">InstanceGuid</param>
        /// <returns></returns>
        public object GetForm(Guid ID) 
        {
            RtForm form = AntApi.DB.RtForms.First(o=>o.FormGuid == ID);
            return form;
        }

        public bool SaveFormData(Guid masterID, object content, Guid formID = new Guid()) 
        {
            RtForm form = null;
            if (formID == null && masterID !=null)
            {
                form = new RtForm();
                form.FormGuid = Guid.NewGuid();
                form.MasterGuid = masterID;
                form.Html = content.ToString();
                form.CreateTime = DateTime.Now;
                AntApi.DB.RtForms.Add(form);
            }
            else
            {
                form = AntApi.DB.RtForms.First(o => o.FormGuid == formID);
                form.Html = content.ToString();
                form.UpdateTime = DateTime.Now;
            }
            AntApi.DB.SaveChanges();
            return true;
        }

        public void SetField(string name, object value) { }

        public object GetField(string name) { return new object(); }
    }
}
