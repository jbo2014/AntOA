using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Ant.Enact;
using Ant.Entity.Bpmx;
using Ant.Entity.Esse;
using Ant.Parse;

namespace Ant.Enact
{
    public class Sequence
    {
        //@ToDo：以后添加默认连线，网关所有分支执行不正确时可以使用

        private BpmContext Context = null;
        private bool exeExpress = false;
        private ExpressionParser eParser = new ExpressionParser();
        private FlowObjParser fParser = new FlowObjParser();
        
        /// <summary>
        /// 获取Token
        /// </summary>
        /// <param name="token"></param>
        public override void TakeToken(BpmContext context) 
        {
            Context = context;
            Execute(Context);
        }

        /// <summary>
        /// 执行条件表达式
        /// </summary>
        /// <param name="args"></param>
        public override bool Execute(BpmContext context) 
        {
            ZSequence sequence = context.Element as ZSequence;

            bool result = this.eParser.GetResult<bool>(sequence.Express);
            if (!exeExpress || (exeExpress && result))
            {
                SendToken(context);
                return true;
            }
            else
            {
                DestroyToken(context.Token);
                return false;
            }
        }

        public void DestroyToken(Token token)
        {
            DoToken doToken = new DoToken();
            doToken.DestroyToken(token);
        }

        // 向后传递Token，多实例节点先合并所有实例节点，然后根据后面的连线分发1至多个Token
        public override void SendToken(BpmContext context)
        {
            ZElement element = fParser.FindRightNode(context.ProcessXml, context.Element.ID) as ZElement;
            Exchange exchange = element.Exchange;
            BpmContext iContext = new BpmContext();
            iContext = context;
            iContext.Element = element;
            exchange.Enter(context);
        }
    }
}
