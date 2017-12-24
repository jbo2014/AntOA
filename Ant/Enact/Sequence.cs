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
    public class Sequence : Exchange
    {
        //public Token token = null;
        public bool exeExpress = false;
        public ExpressionParser eParser = new ExpressionParser();
        
        /// <summary>
        /// 获取Token
        /// </summary>
        /// <param name="token"></param>
        public override void TakeToken(BpmContext context) 
        {
            Context = context;
            Execute(Context);

            logger.Info("获取Token" + Context.Element.ID);
        }

        /// <summary>
        /// 执行条件表达式
        /// </summary>
        /// <param name="args"></param>
        public override void Execute(BpmContext context) 
        {
            ZSequence sequence = context.Element as ZSequence;

            bool result = this.eParser.ExeExpression(sequence.Express);
            if (!exeExpress || (exeExpress && result))
                this.SendToken(context);
            else
                DestroyToken(context.Token);
        }

        public void DestroyToken(Token token)
        {
            DoToken doToken = new DoToken();
            doToken.DestroyToken(token);
        }

        // 向后传递Token，多实例节点先合并所有实例节点，然后根据后面的连线分发1至多个Token
        public override void SendToken(BpmContext context)
        {
            next.FindNextNode(context);
        }
    }
}
