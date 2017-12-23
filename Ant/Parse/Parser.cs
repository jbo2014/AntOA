using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ant.Parse
{
    public interface Parser
    {
        bool ExeExpression(params object[] args);
    }
}
