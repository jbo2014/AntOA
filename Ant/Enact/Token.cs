using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ant.Enact
{
    internal class Token
    {
        public Guid InstanceID;
        public int Count;
        public int Status;  //0：挂起，1：流转中

        public void Signal(Exchange transfer) 
        {
            transfer.Leave();
        }
    }
}
