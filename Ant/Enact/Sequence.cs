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
    internal class Sequence : Exchange
    {
        //public Token token = null;
        public bool exeExpress = false;
        public ZSequence element = new ZSequence();
        public ExpressionParser eParser = new ExpressionParser();
        
        /// <summary>
        /// 获取Token
        /// </summary>
        /// <param name="token"></param>
        public void TakeToken(Stream xml, Token token, ZSequence element) 
        {
            this.Token = token;
            this.element = element;
            Execute(this.element);
        }

        /// <summary>
        /// 执行条件表达式
        /// </summary>
        /// <param name="args"></param>
        public void Execute(ZSequence sequence) 
        {
            bool result = this.eParser.ExeExpression(sequence.Express);
            if (!exeExpress || (exeExpress && result))
                this.SendToken(); 
        }

        // 向后传递Token，多实例节点先合并所有实例节点，然后根据后面的连线分发1至多个Token
        public void SendToken()
        {
            this.LinkNext(this.element.ID, this.Token);
        }
    }
}
