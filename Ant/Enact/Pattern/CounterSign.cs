using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ant.Common;

namespace Ant.Enact.Pattern
{
    /// <summary>
    /// 会签模式
    /// </summary>
    class CounterSign
    {
        /// <summary>
        /// 决策模式
        /// </summary>
        public DecisionEnum Decision { get; set; }

        /// <summary>
        /// 是否等待：
        /// 已可以确定结果的情况下，还有人未表决，是否需要继续等待其他人表决完再转交下一步
        /// </summary>
        public bool NeedWait { get; set; }
    }
}
