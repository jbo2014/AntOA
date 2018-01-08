using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ant.Enact.State
{
    /// <summary>
    /// 活动状态改变接口
    /// </summary>
    public interface IActivity
    {
        /// <summary>
        /// 闲置 转为 初始化
        /// Idle->Inactive
        /// </summary>
        void Start();

        /// <summary>
        /// 初始化 转为 等待
        /// Inactive->Waiting
        /// </summary>
        void Wait();

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
    }
}
