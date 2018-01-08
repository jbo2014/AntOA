using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Ant.Entity.Bpmx;
using Ant.Entity.Esse;
using Ant.Parse;
using NLog;
using Ant.Common;

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
        /// 节点寻找右端所有连接线,重新赋值Context
        /// </summary>
        /// <param name="iContext"></param>
        /// <param name="exeExpress"></param>
        public void FindNextLines(BpmContext context, bool exeExpress = false)
        {
            List<ZSequence> lines = fParser.FindRightLines(context.ProcessXml, context.Element.ID) as List<ZSequence>;
            Token token = null;
            foreach (ZSequence line in lines)
            {
                Exchange exchange = line.Exchange;
                BpmContext iContext = new BpmContext();

                token = new Token();
                token.InstanceID = context.InstanceID;
                token.TokenID = Guid.NewGuid();
                token.ElementID = context.Element.ID;
                token.Status = TokenStatus.Waiting;

                iContext.InstanceID = context.InstanceID;
                iContext.Element = line;
                iContext.Token = token;
                iContext.ProcessXml = context.ProcessXml;
                exchange.Enter(iContext);
            }
        }
        #endregion
    }
}
