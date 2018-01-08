using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Model;
using Ant.Enact;
using Ant.Service;
using Ant.Parse;
using Ant.Entity.Esse;
using Ant.Entity.Bpmx;
using Ant.Enact.Operate;
using Ant.Utility;
using Ant.Enact.Activity;

namespace Ant.Enact
{
    /// <summary>
    /// 工作机
    /// 文件夹结构：
    ///     Impl，各类具体元素执行
    ///     Operate，人为控制流程
    ///     Pattern，流转模式，顺序、并发、排他、包含等
    ///     State，状态改变事件，关联改变过程、活动、任务的状态
    /// </summary>
    public class EnactService
    {
        #region 属性定义
        public BpmContext Context { get; set; }
        #endregion


        #region 功能定义
        //#region 解释过程定义
        //#endregion

        #region 控制过程实例-创建、激活、挂起、终止等
        /// <summary>
        /// 启动/激活流程实例
        /// </summary>
        public void Start(BpmContext context) 
        {
            Transfer transfer = new Transfer();
            transfer.Start(context);
        }

        public void Next(Guid InstanceGuid, Guid TaskGuid) 
        {
            RtInstance instance = AntApi.DB.RtInstances.First(o => o.InstanceGuid == InstanceGuid);
            RtTask task = AntApi.DB.RtTasks.First(o => o.TaskGuid == TaskGuid);
            string ActivityID = AntApi.DB.RtActivitys.First(o => o.ActivityGuid == task.ActivityGuid).ActivityID;
            Stream xml = StreamUtil.StreamFromString(instance.ProcessXml);

            FlowObjParser fParser = new FlowObjParser();

            ZUserTask zUserTask = fParser.FindNode<ZUserTask>(xml, "UserTask", ActivityID);
            
            BpmContext context = new BpmContext();
            context.InstanceID = InstanceGuid;
            context.ProcessXml = xml;
            context.Element = zUserTask;

            Exchange userTask = zUserTask.Exchange;
            userTask.Leave(context);
        }

        ///// <summary>
        ///// 挂起流程
        ///// </summary>
        //public void Suspend() 
        //{

        //}

        ///// <summary>
        ///// 由Suspended状态恢复到Running状态
        ///// </summary>
        //public void Resume() { }

        ///// <summary>
        ///// 终止流程
        ///// </summary>
        //public void Terminate() { }
        #endregion

        //#region 为过程中的活动导航，可能要包含顺序或平行的操作，最后时间期限、对工作流相关数据进行解释
        //#endregion

        //#region 参与者签名、退出
        //#endregion

        //#region 确定任务，实现用户意图：提供接口，支持用户交互
        //#endregion

        //#region 维护工作流控制数据和工作流相关数据，在应用程序间或者用户间传递工作流相关数据
        //#endregion

        //#region 提供调用外部程序的接口，连接所有工作流相关数据
        //#endregion

        //#region 控制、管理、审查功能
        //#endregion
        #endregion


    }
}
