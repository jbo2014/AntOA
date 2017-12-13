using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ant.Enact
{
    /// <summary>
    /// 用于流程的流转操作
    /// </summary>
    class Transfer
    {
        /// <summary>
        /// 按照流程图正常流转至下一个节点
        /// </summary>
        public void GoNext(){}

        /// <summary>
        /// 回退到上一个节点
        /// </summary>
        public void GoBack() { }

        /// <summary>
        /// 回退到之前历史节点的任一节点
        /// </summary>
        public void JumpBack() { }

        /// <summary>
        /// 跳转到流程图中当前节点之后的任一节点
        /// </summary>
        public void JumpNext() { }

        /// <summary>
        /// 撤回：已经转交出去的任务，只要下一节点没有处理即可
        /// </summary>
        public void Withdraw() { }
    }
}
