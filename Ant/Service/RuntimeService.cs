using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ant.Entity.BPM;

namespace Ant.Service
{
    /// <summary>
    /// 运行时服务
    /// </summary>
    public class RuntimeService
    {
        /// <summary>
        /// 发起一个新流程
        /// </summary>
        public ZProcess StartInstance(string processId)
        {
            return new ZProcess();
        }
    }
}
