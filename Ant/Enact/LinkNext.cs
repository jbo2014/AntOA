using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ant.Entity.Bpmx;
using Ant.Entity.Esse;
using Ant.Parse;

namespace Ant.Enact
{
    /// <summary>
    /// 两个元素间的连接处理
    /// </summary>
    public class LinkNext
    {
        public FlowObjParser parser = new FlowObjParser();
        /// <summary>
        /// 节点寻找右端所有连接线,重新赋值Context
        /// </summary>
        /// <param name="iContext"></param>
        /// <param name="exeExpress"></param>
        public void FindNextLines(BpmContext context, bool exeExpress = false)
        {
            List<ZSequence> lines = parser.FindRightLines(context.ProcessXml, context.Element.ID) as List<ZSequence>;
            foreach (ZSequence line in lines)
            {
                Exchange exchange = line.Exchange;
                BpmContext iContext = new BpmContext();
                iContext.Element = line;
                iContext.Token = context.Token;
                iContext.ProcessXml = context.ProcessXml;
                exchange.TakeToken(iContext);
            }
        }

        /// <summary>
        /// 连线寻找右端节点,重新赋值Context
        /// </summary>
        /// <param name="context"></param>
        public void FindNextNode(BpmContext context)
        {
            ZElement element = parser.FindRightNode(context.ProcessXml, context.Element.ID) as ZElement;
            Exchange exchange = element.Exchange;
            BpmContext iContext = new BpmContext();
            iContext.Element = element;
            iContext.Token = context.Token;
            iContext.ProcessXml = context.ProcessXml;
            exchange.TakeToken(context);
        }
    }
}
