using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Ant.Service
{
    /// <summary>
    /// 流程定义文件解析、配置接口
    /// </summary>
    public class ProcessService : BaseService
    {
        #region 属性声明
        #endregion

        #region 方法
        /// <summary>
        /// 获取流程列表
        /// </summary>
        /// <returns></returns>
        public List<WfProcess> GetProcessList()
        {
            List<WfProcess> processes = db.WfProcess.Where(o=>o.Status==1).ToList();
            return processes;
        }
        #endregion
    }
}
