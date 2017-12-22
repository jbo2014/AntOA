using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ant.Entity.Esse;

namespace Ant.Action
{
    internal class IAction
    {
        /// <summary>
        /// 行为定义
        /// </summary>
        public string Define { get; set; }

        /// <summary>
        /// 行为执行结果：0未执行，1执行成功，2执行失败
        /// </summary>
        public ActionResult Result { get; set; }


        /// <summary>
        /// 执行行为
        /// </summary>
        public object Fire() { return new object(); }
    }
}
