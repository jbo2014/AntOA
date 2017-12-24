using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ant.Entity.Esse;
using Ant.Entity.Bpmx;
using Ant.Action;
using Ant.Common;

namespace Ant.Enact.Event
{
    public class EndEvent : Exchange
    {
        #region 继承重写的方法
        /// <summary>
        /// 重写接收事件
        /// </summary>
        public override void TakeToken(BpmContext context)
        {
            Context = context;
            Execute(Context);
        }

        /// <summary>
        /// 具体业务逻辑
        /// </summary>
        /// <param name="context"></param>
        public override void Execute(BpmContext context)
        {
            ZEndEvent ender = Context.Element as ZEndEvent;
            Throwing(ender);
            //结束 流程 或 流程中一个分支
            FinishProcess(context);

            logger.Info("执行" + Context.Element.ID);
        }
        #endregion

        #region 自己独有的方法
        /// <summary>
        /// 捕获事件
        /// </summary>
        private void Throwing(ZEndEvent element)
        {
            string elementType = string.Empty;
            if (string.IsNullOrEmpty(element.Type))
                elementType = "None";
            else
                elementType = element.Type;
            element = new ZEndEvent();
            Type type = Type.GetType(typeof(IAction).Namespace + "." + elementType + "Action");
            IAction act = System.Activator.CreateInstance(type) as IAction;
            act.Define = element.Define;
            act.Fire();

            FinishProcess(Context);
        }

        private void FinishProcess(BpmContext context)
        {
            context.Token = null;
        }
        #endregion
    }
}
