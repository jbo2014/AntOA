using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Ant.Entity.Bpmx;

namespace Ant.Entity.Esse
{
    public class BpmContext
    {
        /// <summary>
        /// 当前流程实例的GuID
        /// </summary>
        public Guid InstanceID;

        /// <summary>
        /// 当前流程实例对应Repository的GuID
        /// </summary>
        public Guid RepoID;

        /// <summary>
        /// 当前流程定义文件的流
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
