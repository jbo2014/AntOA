using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Ant.Entity.Bpmx;
using Ant.Entity.Esse;
using Ant.Parse;
using NLog;

namespace Ant.Enact
{
    /// <summary>
    /// 流转基类
    /// </summary>
    public class Exchange
    {
        public FlowObjParser fParser = new FlowObjParser();
        public ExpressionParser eParser = new ExpressionParser();
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public LinkNext next = new LinkNext();
        public BpmContext Context { get; set; }

        #region 流程转换
        // 获取Token，如果节点是多实例的则分发成多个Token
        public virtual void Enter(BpmContext context) 
        { 
            Context = context; Execute(Context); 
        }

        // 执行节点内容
        public virtual void Execute(BpmContext context) 
        {
            Leave(Context); 
        }

        // 向后传递Token，多实例节点先合并所有实例节点，然后根据后面的连线分发1至多个Token
        public virtual void Leave(BpmContext context) {  }
        #endregion

        #region 中间状态转变
        /// <summary>
        /// 等待处理：例如，流转到用户任务，流程需要等待用户办理。
        ///          流程不能停止，需要特别处理
        /// </summary>
        public virtual void WaiteHandle(BpmContext context) 
        {

        }
        #endregion
    }
}
