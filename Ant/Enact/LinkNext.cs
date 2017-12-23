using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ant.Entity.Bpmx;
using Ant.Entity.Esse;
using Ant.Parse;

namespace Ant.Enact
{
    public class LinkNext
    {
        public FlowObjParser parser = new FlowObjParser();
        /// <summary>
        /// 寻找节点右端所有连接线,重新赋值Context
        /// </summary>
        /// <param name="iContext"></param>
        /// <param name="exeExpress"></param>
        public void FindNextLines(Context iContext, bool exeExpress = false)
        {
            List<ZSequence> lines = parser.FindRightLines(iContext.ProcessXml, iContext.Element.ID) as List<ZSequence>;
            foreach (ZSequence line in lines)
            {
                Exchange exchange = line.Exchange;
                Context context = new Context();
                context.Element = line;
                context.Token = iContext.Token;
                context.ProcessXml = iContext.ProcessXml;
                exchange.TakeToken(context);
            }
        }

        /// <summary>
        /// 寻找连线右端节点,重新赋值Context
        /// </summary>
        /// <param name="context"></param>
        public void FindNextNode(Context context)
        {
            ZElement element = parser.FindRightNode(context.ProcessXml, context.Element.ID) as ZElement;
            Exchange exchange = element.Exchange;
            exchange.TakeToken(context);
        }
    }
}
