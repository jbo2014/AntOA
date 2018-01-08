using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ant.Enact.State
{
    /// <summary>
    /// 流程状态改变接口
    /// </summary>
    public interface IProcess
    {
        /// <summary>
        /// 闲置 转为 初始化
        /// Idle->Inactive
        /// </summary>
        void Start();

        /// <summary>
        /// Waiting->Running
        /// </summary>
        void Run();

        /// <summary>
        /// Running->Suspended
        /// Waiting->Suspended
        /// </summary>
        void Suspend();

        /// <summary>
        /// 由Suspended恢复Running状态
        /// Suspended->Running
        /// Suspended->Waiting
        /// </summary>
        void Resume();

        /// <summary>
        /// 人为终止
        /// Running->Terminated
        /// </summary>
        void Terminate();

        /// <summary>
        /// 自然完成
        /// Running->Completed
        /// </summary>
        void Complete();

        /// <summary>
        /// Suspened->abort
        /// </summary>
        void Abort();

        /// <summary>
        /// Inactive->Cancel
        /// </summary>
        void Cancel();
    }
}
