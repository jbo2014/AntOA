using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ant.Entity.Bpmx;
using Ant.Entity.Esse;
using Ant.Common;

namespace Ant.Enact.Gateway
{
    /// <summary>
    /// 排他网关
    /// </summary>
    class ExclusiveGateway : Exchange
    {
        ZSequence inSequence = new ZSequence();
        ZSequence outSequence = new ZSequence();

        #region 聚合顺序流的处理
        public override void Execute(BpmContext context)
        {
            MergeExecute(context);
            SplitExecute(context);
            Leave(context);
        }

        /// <summary>
        /// 聚合顺序流的处理
        /// </summary>
        /// <param name="context"></param>
        public void MergeExecute(BpmContext context)
        {
            //获取网关所有输入连线
            List<ZSequence> lines = fParser.FindOneSideLines(context.ProcessXml, context.Element.ID, false) as List<ZSequence>;
            bool exeResult = false; //连线上表达式的执行结果
            foreach (ZSequence line in lines)
            {
                if (string.IsNullOrEmpty(line.Express))
                {
                    exeResult = eParser.GetResult<bool>(line.Express);
                    if (exeResult)
                    {
                        inSequence = line;
                        break;
                    }
                }
            }
        }
        #endregion

        #region 分支顺序流的处理
        /// <summary>
        /// 分支顺序流的处理
        /// </summary>
        /// <param name="context"></param>
        public void SplitExecute(BpmContext context)
        {
            //获取网关所有输入连线
            List<ZSequence> lines = fParser.FindOneSideLines(context.ProcessXml, context.Element.ID, true) as List<ZSequence>;
            bool exeResult = false; //连线上表达式的执行结果
            foreach (ZSequence line in lines)
            {
                if (string.IsNullOrEmpty(line.Express))
                {
                    exeResult = eParser.GetResult<bool>(line.Express);
                    if (exeResult)
                    {
                        outSequence = line;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// 发送Token
        /// </summary>
        /// <param name="context"></param>
        public void Leave(BpmContext context)
        {
            Exchange exchange = outSequence.Exchange;
            BpmContext iContext = new BpmContext();
            iContext.Element = outSequence;
            iContext.Token = context.Token;
            iContext.ProcessXml = context.ProcessXml;
            exchange.Enter(iContext);
        }
        #endregion
    }
}
