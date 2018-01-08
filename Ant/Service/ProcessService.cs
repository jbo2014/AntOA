using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Model;
using Ant.Entity.Bpmx;
using Ant.Entity.Esse;
using Ant.Parse;
using Ant.Utility;

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

        #region 流程定义版本处理
        //1.修改当前版本：只修改当前版本的定义。WfRepo中的MasterVer不修改
        //2.建立新版本：将修改中的当前版本复制一份，作为新版本。同时修改WfRepo中的MasterVer
        //3.同步实例化：按时间、实例标题、全部实例三种情况同步
        #endregion


        /// <summary>
        /// 部署流程定义
        /// 上传定义文件，解析成Xpdl对象
        /// </summary>
        /// <param name="process"></param>
        /// <returns></returns>
        //public WfProcess ProcessDeploy(ZProcess process)
        //{
        //    return new WfProcess();
        //}

        /// <summary>
        /// 获取流程定义列表
        /// </summary>
        /// <returns></returns>
        public List<WfProcess> GetProcessList()
        {
            List<WfProcess> processes = db.WfProcesss.Where(o=>o.Status==1).ToList();
            return processes;
        }
        
        /// <summary>
        /// 获取流程中所有定义的字段
        /// </summary>
        /// <returns></returns>
        public string GetAllProcessFieldsByContext(BpmContext context = null) 
        {
            Stream xml = null;
            List<ZParam> paramList = new List<ZParam>();
            if(context==null)
            {
                xml=Context.ProcessXml;
            }
            else
            {
                xml=context.ProcessXml;
            }
            FlowObjParser fParser = new FlowObjParser();
            paramList = fParser.GetElementList<ZParam>(xml, "Param");

            return JsonConvert.SerializeObject(paramList);
        }

        /// <summary>
        /// 获取流程中所有定义的字段
        /// </summary>
        /// <returns></returns>
        public string GetAllProcessFieldsByRepoGuid(Guid repoGuid)
        {
            List<ZParam> paramList = new List<ZParam>();
            WfRepository repo = db.WfRepositorys.First(o => o.RepoGuid == repoGuid);
            FlowObjParser fParser = new FlowObjParser();
            paramList = fParser.GetElementList<ZParam>(StreamUtil.StreamFromString(repo.BpmContent), "Param");

            return JsonConvert.SerializeObject(paramList);
        }

        public WfRepository GetMasterRepoByProcess(Guid processGuid) 
        {
            WfProcess process = db.WfProcesss.First(o=>o.ProcessGuid==processGuid);
            return db.WfRepositorys.First(o => o.ProcessGuid == processGuid && o.Version == process.MasterVer);
        }
        #endregion
    }
}
