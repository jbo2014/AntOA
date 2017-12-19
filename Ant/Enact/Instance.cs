using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Ant.Enact
{
    /// <summary>
    /// 流程实例
    /// </summary>
    class Instance
    {
        public Instance NewInstance(WfProcess process) 
        {
            return new Instance();
        }
    }
}
