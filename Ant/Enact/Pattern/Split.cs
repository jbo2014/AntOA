using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ant.Entity.Bpmx;
using Ant.Entity.Esse;
using Ant.Common;
using Ant.Parse;

namespace Ant.Enact.Pattern
{
    /// <summary>
    /// 分裂模式
    /// </summary>
    public class Split
    {

        public FlowObjParser fParser = new FlowObjParser();

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

                iContext.Element = line;
                iContext.Token = token;
                iContext.ProcessXml = context.ProcessXml;
                exchange.Enter(iContext);
            }
        }
    }
}
