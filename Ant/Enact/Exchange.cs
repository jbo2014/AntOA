using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Ant.Entity.Bpmx;
using Ant.Entity.Esse;
using Ant.Parse;
using NLog;

namespace Ant.Enact
{
    /// <summary>
    /// 流转基类
    /// </summary>
    public class Exchange
    {
        public FlowObjParser fParser = new FlowObjParser();
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public LinkNext next = new LinkNext();
        //public ZElement Element { get; set; }
        //public Stream ProcessXml { get; set; }
        //public Token Token { get; set; }
        public BpmContext Context { get; set; }

        //public Exchange() {}
        //public Exchange(Stream processXml, ZElement element)
        //{
        //    this.ProcessXml = processXml;
        //    this.Element = element;
        //}

        #region 流程转换
        // 获取Token，如果节点是多实例的则分发成多个Token
        public virtual void TakeToken(BpmContext context) { this.Execute(Context); }

        //public virtual void TakeToken(params object[] args);

        // 进入节点
        //public virtual void Enter(params object[] args) { this.Execute(); }

        // 执行节点内容
        public virtual void Execute(BpmContext context) { this.SendToken(Context); }

        // 离开节点
        //public virtual void Leave(params object[] args) { this.SendToken(); }

        // 向后传递Token，多实例节点先合并所有实例节点，然后根据后面的连线分发1至多个Token
        public virtual void SendToken(BpmContext context) { }
        #endregion

        #region 中间状态转变
        /// <summary>
        /// 等待处理：例如，流转到用户任务，流程需要等待用户办理。
        ///          流程不能停止，需要特别处理
        /// </summary>
        public virtual void WaiteHandle(BpmContext context) 
        {
            
        }

    }
}
