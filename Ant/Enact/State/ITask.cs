using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ant.Enact.State
{
    /// <summary>
    /// 任务状态改变接口
    /// </summary>
    public interface ITask
    {
        /// <summary>
        /// Idle->Created
        /// </summary>
        void Create();

        /// <summary>
        /// 领用
        /// Created->Received
        /// </summary>
        void Receive();

        /// <summary>
        /// 拒绝
        /// Received->Terminated
        /// </summary>
        void Reject();

        /// <summary>
        /// 执行
        /// </summary>
        void Run();

        /// <summary>
        /// 挂起
        /// </summary>
        void Suspend();

        /// <summary>
        /// 由挂起恢复为执行
        /// </summary>
        void Resume();

        /// <summary>
        /// 人为终止
        /// </summary>
        void Terminate();

        /// <summary>
        /// 自然完成
        /// </summary>
        void Complete();
    }
}
