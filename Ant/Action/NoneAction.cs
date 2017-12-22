using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ant.Common;

namespace Ant.Action
{
    internal class NoneAction : IAction
    {
        public NoneAction() 
        {
            this.Result.Code = ResultEnum.Success;
            this.Result.Message = "";
        }
    }
}
