using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Ant.Service
{
    /// <summary>
    /// 表单服务：启动表单 和 任务表单
    /// </summary>
    public class FormService : BaseService
    {
        public bool Submit()
        {
            return true;
        }

        public bool SaveData(string id, string value)
        {
            db.FmDatas.Add(new FmData(){FormGuid=Guid.NewGuid(), FormID="", WidgetID=id, Value=value});
            db.SaveChanges();
            return true;
        }
    }
}
