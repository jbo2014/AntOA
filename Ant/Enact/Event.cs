using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ant.Action;

namespace Ant.Enact
{
    /// <summary>
    /// 
    /// </summary>
    internal interface Event
    {
        Token Token { get; set; }

        /// <summary>
        /// 捕获事件
        /// </summary>
        void Catching(IAction act);

        /// <summary>
        /// 触发事件
        /// </summary>
        void Throwing();

        /// <summary>
        /// 接收Token
        /// </summary>
        void ReceiveToken();

        /// <summary>
        /// 发送Token
        /// </summary>
        void SendToken();
    }
}
