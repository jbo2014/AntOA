using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ant.Action;
using Ant.Entity.Bpmx;

namespace Ant.Enact.Xpdl
{
    internal class StartEvent : Exchange
    {
        public Token Token
        {
            get { return this.Token; }
            set { this.Token = value; }
        }

        #region 继承重写的方法
        // 离开节点,this.Take();
        public void Leave() { }

        // 连线获取Token,this.Enter();
        public void Take() { }

        // 进入节点
        public void Enter(ZStartEvent start)
        {
            //Catching(action);
        }
        #endregion

        #region 自己独有的方法
        /// <summary>
        /// 捕获事件
        /// </summary>
        public void Catching(IAction act)
        {
            if (act.Result.Code == 1)
                SendToken();
        }

        public void CatchingMsg(IAction act)
        {
            if (act.Result.Code == 1)
                SendToken();
        }

        public void CatchingTimer(IAction act)
        {
            if (act.Result.Code == 1)
                SendToken();
        }

        /// <summary>
        /// 发送Token
        /// </summary>
        public void SendToken()
        {

        }
        #endregion
    }
}
