using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using Ant.Entity.Bpmx;
using Ant.Parse;

namespace Ant.Enact
{
    /// <summary>
    /// 用于流程的流转操作
    /// </summary>
    internal class Transfer
    {
        Exchange exchange = null;
        FlowObjParser parser = new FlowObjParser();

        #region 流程实例级别操作
        /// <summary>
        /// 启动流程
        /// </summary>
        public void Start(Stream xml)
        {
            List<ZStartEvent> starters = parser.FindStartNode(xml);
            foreach (ZStartEvent starter in starters)
            {
                exchange = starter.Exchange;
                exchange.Execute(starter);
            }
        }

        /// <summary>
        /// 结束流程
        /// </summary>
        public void End()
        { }

        /// <summary>
        /// 挂起流程
        /// </summary>
        public void Suspend()
        { }

        /// <summary>
        /// 恢复已经结束的流程实例
        /// </summary>
        public void Resume() { }
        #endregion

        #region 流程实例任务的流转
        /// <summary>
        /// 按照流程图正常流转至下一个节点
        /// </summary>
        public void Run(string processXml, ZStep step)
        {
        }

        /// <summary>
        /// 回退到上一个节点
        /// </summary>
        public void Back() { }

        /// <summary>
        /// 跳转到流程图中任一节点
        /// </summary>
        public void Jump() { }

        /// <summary>
        /// 撤回：已经转交出去的任务，只要下一节点没有处理即可撤回
        /// </summary>
        public void Withdraw() { }
        #endregion
    }
}
