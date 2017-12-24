using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ant.Entity.Esse
{
    public class Token
    {
        public Guid InstanceID;
        public string TokenID;
        public string ElementID;
        public int Status;  //0：挂起（等待），1：激活，2：销毁
    }
}
