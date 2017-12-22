using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ant.Entity.Esse
{
    internal class Token
    {
        public Guid InstanceID;
        public string TokenID;
        public string ElementID;
        //public int Count;
        public int Status;  //0：挂起，1：激活
    }
}
