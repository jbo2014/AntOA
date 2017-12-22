using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ant.Enact;

namespace Ant.Entity.Bpmx
{
    public interface ZElement
    {
        string ID { get; set; }
        Exchange Exchange { get; set; }
    }
}
