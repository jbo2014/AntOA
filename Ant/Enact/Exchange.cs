using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Ant.Entity.Bpmx;
using Ant.Entity.Esse;
using Ant.Parse;

namespace Ant.Enact
{
    /// <summary>
    /// 流转基类
    /// </summary>
    public interface Exchange
    {
        //public FlowObjParser FlowObjParser = new FlowObjParser();
        public DoToken DoToken = new DoToken();
        //public ZElement Element { get; set; }
        //public Stream ProcessXml { get; set; }
        //public Token Token { get; set; }
        public Context Context { get; set; }

        //public Exchange() {}
        //public Exchange(Stream processXml, ZElement element)
        //{
        //    this.ProcessXml = processXml;
        //    this.Element = element;
        //}

        #region 流程转换
        // 获取Token，如果节点是多实例的则分发成多个Token
        void TakeToken(Context context) { }

        //public virtual void TakeToken(params object[] args);

        // 进入节点
        //public virtual void Enter(params object[] args) { this.Execute(); }

        // 执行节点内容
        void Execute(Context context) { }

        // 离开节点
        //public virtual void Leave(params object[] args) { this.SendToken(); }

        // 向后传递Token，多实例节点先合并所有实例节点，然后根据后面的连线分发1至多个Token
        void SendToken(Context context) { }
        #endregion
    }
}
