using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ant.Enact;
using Ant.Enact.Xpdl;

namespace Ant.Entity.Bpmx
{
    internal class ZStartEvent : ZElement
    {
        public Exchange Exchange 
        {
            get 
            {
                return new StartEvent();
            }
            set 
            {
                this.Exchange = value;
            }
        }
    }
}
