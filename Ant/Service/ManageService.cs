using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Ant.Service
{
    public class ManageService : BaseService
    {
        /// <summary>
        /// 获取流程定义列表
        /// </summary>
        /// <returns></returns>
        public List<WfProcess> GetProcessList()
        {
            List<WfProcess> processes = db.WfProcesss.ToList();
            return processes;
        }

        /// <summary>
        /// 获取实例列表
        /// </summary>
        /// <returns></returns>
        public List<RtInstance> GetInstanceList() 
        {
            List<RtInstance> instances = db.RtInstances.ToList();
            return instances;
        }

        /// <summary>
        /// 获取定义/实例表单列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="isCase"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<T> GetFormList<T>(bool isCase, Guid id)
        {
            List<T> ts = default(List<T>);
            if(isCase)
                ts = AntApi.Former.GetInstanceFormList(id) as List<T>;
            else
                ts = AntApi.Former.GetProcessFormList(id) as List<T>;
            return ts;
        }
    }
}
