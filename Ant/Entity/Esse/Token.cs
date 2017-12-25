using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ant.Common;

namespace Ant.Entity.Esse
{
    public class Token
    {
        public Guid InstanceID;

        //上一级Token的ID
        public Guid ParentToken;

        public Guid TokenID;
        
        public string ElementID;
        
        //0：挂起（等待），1：激活，2：销毁
        public TokenStatus Status;  
    }
}
