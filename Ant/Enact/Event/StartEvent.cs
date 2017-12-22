using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Ant.Action;
using Ant.Entity.Bpmx;
using Ant.Entity.Esse;
using Ant.Common;

namespace Ant.Enact.Event
{
    internal class StartEvent : Exchange
    {
        public ZStartEvent element = null;

        #region 继承重写的方法
        public void Execute(StartEvent starter) 
        {
            Catching(starter);
            SendToken();
        }

        /// <summary>
        /// 重写发送事件
        /// </summary>
        public void SendToken() 
        {
            LinkNext(this.element.ID, this.Token);
        }
        #endregion

        #region 自己独有的方法
        /// <summary>
        /// 捕获事件
        /// </summary>
        private void Catching(StartEvent starter)
        {
            string elementType = string.Empty;
            if (string.IsNullOrEmpty(element.Type))
                elementType = "None";
            else
                elementType = element.Type;
            element = new ZStartEvent();
            Type type = Type.GetType(elementType + "Action");
            IAction act = System.Activator.CreateInstance(type) as IAction;
            act.Define = element.Define;
            act.Fire();
            if (act.Result.Code == ResultEnum.Success)
                CreateToken();
            else if (act.Result.Code == ResultEnum.Fail)
                DestroyToken();
        }

        private void DestroyToken()
        {
            this.Token = null;
        }
        
        private void CreateToken() 
        {
            this.Token = new Token();
            this.Token.InstanceID = Guid.NewGuid();
            this.Token.ElementID = this.element.ID;
            this.Token.Status = 1;
        }
        #endregion
    }
}
