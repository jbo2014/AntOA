using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ant.Common;

namespace Ant.Action
{
    public class NoneAction : IAction
    {
        public NoneAction() 
        {
            this.Result = new Entity.Esse.ActionResult() { Code = ResultEnum.Success, Message = "" };
        }
    }
}
