using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Ant.Entity.Bpmx;

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
        /// 部署流程定义
        /// 上传定义文件，解析成Xpdl对象
        /// </summary>
        /// <param name="process"></param>
        /// <returns></returns>
        public WfProcess ProcessDeploy(ZProcess process)
        {
            return new WfProcess();
        }

        /// <summary>
        /// 获取流程定义列表
        /// </summary>
        /// <returns></returns>
        public List<WfProcess> GetProcessList()
        {
            List<WfProcess> processes = db.WfProcesss.Where(o=>o.Status==1).ToList();
            return processes;
        }
        #endregion
    }
}
