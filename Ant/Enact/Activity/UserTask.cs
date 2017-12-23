using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Ant.Entity.Bpmx;
using Ant.Entity.Esse;

namespace Ant.Enact.Activity
{
    public class UserTask : Exchange
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="xml"></param>
        /// <param name="token"></param>
        /// <param name="element"></param>
        public void TakeToken(Context context)
        {
            Context.Token = context.Token;
            Context.Element = context.Element;
            Execute(Context);
        }
    }
}
