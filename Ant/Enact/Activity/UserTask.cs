using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Ant.Entity.Bpmx;
using Ant.Entity.Esse;

namespace Ant.Enact.Activity
{
    internal class UserTask : Exchange
    {
        public ZUserTask element;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xml"></param>
        /// <param name="token"></param>
        /// <param name="element"></param>
        public void TakeToken(Stream xml, Token token, ZUserTask element)
        {
            this.Token = token;
            this.element = element;
            Execute();
        }
    }
}
