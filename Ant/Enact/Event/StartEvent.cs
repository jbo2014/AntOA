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
    public class StartEvent : Exchange
    {
        #region 继承重写的方法
        public override void Execute(Context context) 
        {
            Context = context;
            ZStartEvent starter = Context.Element as ZStartEvent;
            Catching(starter);
            SendToken(Context);
        }

        /// <summary>
        /// 重写发送事件
        /// </summary>
        public override void SendToken(Context context) 
        {
            FindNextLines(context.Element.ID, context.Token);
        }
        #endregion

        #region 自己独有的方法
        /// <summary>
        /// 捕获事件
        /// </summary>
        private void Catching(ZStartEvent element)
        {
            string elementType = string.Empty;
            if (string.IsNullOrEmpty(element.Type))
                elementType = "None";
            else
                elementType = element.Type;
            element = new ZStartEvent();
            Type type = Type.GetType(typeof(IAction).Namespace + "." + elementType + "Action");
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
            Context.Token = null;
        }
        
        private void CreateToken() 
        {
            Context.Token = new Token();
            Context.Token.InstanceID = Guid.NewGuid();
            Context.Token.ElementID = Context.Element.ID;
            Context.Token.Status = 1;
        }
        #endregion
    }
}
