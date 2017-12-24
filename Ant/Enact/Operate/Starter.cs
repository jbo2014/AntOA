using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ant.Parse;
using Ant.Entity.Esse;
using Ant.Entity.Bpmx;

namespace Ant.Enact.Operate
{
    /// <summary>
    /// 一般性流程控制
    /// </summary>
    public class Starter
    {
        Exchange exchange = null;
        FlowObjParser fParser = new FlowObjParser();

        /// <summary>
        /// 从流程定义的开始事件启动流程
        /// </summary>
        /// <param name="context"></param>
        public void Start(BpmContext context)
        {
            List<ZStartEvent> starters = fParser.FindStartNode(context.ProcessXml);
            foreach (ZStartEvent starter in starters)
            {
                context.Element = starter;

                exchange = starter.Exchange;
                exchange.Execute(context);
            }
        }

        /// <summary>
        /// 从流程定义的任意节点启动流程：非开始事件节点
        /// </summary>
        /// <param name="context"></param>
        public void StartFromAny(BpmContext context)
        {
            
        }
    }
}
