using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ant.Entity.BPM
{
    public class ZSequence
    {
        public string id;

        /// <summary>
        /// 连接线的起始节点
        /// </summary>
        public string source;

        /// <summary>
        /// 连接线的目标节点
        /// </summary>
        public string target;

        /// <summary>
        /// 连接线上的表达式
        /// </summary>
        public string lineExpress;
    }
}
