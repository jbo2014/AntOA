using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ant.Enact.State
{
    abstract class VProcess
    {
        /// <summary>
        /// 闲置 转为 初始化
        /// Idle->Inactive
        /// </summary>
        public void Start(){}

        /// <summary>
        /// Waiting->Running
        /// </summary>
        public void Run(){}

        /// <summary>
        /// Running->Suspended
        /// Waiting->Suspended
        /// </summary>
        public void Suspend(){}

        /// <summary>
        /// 由Suspended恢复Running状态
        /// Suspended->Running
        /// Suspended->Waiting
        /// </summary>
        public void Resume(){}

        /// <summary>
        /// 人为终止
        /// Running->Terminated
        /// </summary>
        public void Terminate(){}

        /// <summary>
        /// 自然完成
        /// Running->Completed
        /// </summary>
        public void Complete(){}

        /// <summary>
        /// Suspened->abort
        /// </summary>
        public void Abort(){}

        /// <summary>
        /// Inactive->Cancel
        /// </summary>
        public void Cancel(){}
    }
}
