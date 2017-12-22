using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;
using Ant.Entity.Esse;

namespace Ant.Enact
{
    internal interface FlowObject
    {
        List<Token> Tokens { get;set; }

        Logger Logging { get; set; }
    }
}
