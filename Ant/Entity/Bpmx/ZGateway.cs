using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ant.Entity.Bpmx
{
    public class ZGateway : ZBlock
    {
        /// <summary>
        /// 聚合模式
        /// 排他exclusive(XOR)/并行parallel(AND)/包含inclusive(OR)/基于事件event(EVE)
        /// </summary>
        public string JoinPattern;  

        /// <summary>
        /// 聚合表达式
        /// </summary>
        public string JoinExpress;

        /// <summary>
        /// 分支模式
        /// 排他exclusive(XOR)/并行parallel(AND)/包含inclusive(OR)/基于事件event(EVE)
        /// </summary>
        public string ForkPattern;

        /// <summary>
        /// 分支表达式
        /// </summary>
        public string ForkExpress;

        /// <summary>
        /// 表达式
        /// </summary>
        public string Express;
    }
}
