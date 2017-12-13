﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ant.Entity.BPM
{
    public class ZGateway : ZElement
    {
        /// <summary>
        /// 聚合模式
        /// 排他exclusive/并行parallel/包含inclusive/基于事件event
        /// </summary>
        public string joinPattern;  

        /// <summary>
        /// 聚合表达式
        /// </summary>
        public string joinExpress;

        /// <summary>
        /// 分支模式
        /// 排他exclusive/并行parallel/包含inclusive/基于事件event
        /// </summary>
        public string forkPattern;

        /// <summary>
        /// 分支表达式
        /// </summary>
        public string forkExpress;

        /// <summary>
        /// 表达式
        /// </summary>
        public string express;
    }
}