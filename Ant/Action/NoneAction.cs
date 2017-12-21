using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ant.Action
{
    internal class NoneAction : IAction
    {
        public NoneAction() 
        {
            this.Result.Code = 1;
            this.Result.Message = "";
        }
    }
}
