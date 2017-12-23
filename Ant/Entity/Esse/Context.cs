using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Ant.Entity.Bpmx;

namespace Ant.Entity.Esse
{
    public class Context
    {
        /// <summary>
        /// 当前流程定义的流
        /// </summary>
        public Stream ProcessXml;

        /// <summary>
        /// 当前执行的单元
        /// </summary>
        public ZElement Element;

        /// <summary>
        /// 当前执行单元所持有的令牌
        /// </summary>
        public Token Token;
    }
}
