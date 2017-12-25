using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Model;
using Ant.Entity.Bpmx;
using Ant.Entity.Esse;

namespace Ant.Enact.Activity
{
    public class UserTask : Exchange
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="xml"></param>
        /// <param name="token"></param>
        /// <param name="element"></param>
        public override void Enter(BpmContext context)
        {
            Context = context;

            WfTask task = new WfTask();
            ZUserTask userTask = context.Element as ZUserTask;

            task.TaskGuid = Guid.NewGuid();
            task.InstanceGuid = context.InstanceID;
            task.NodeID = context.Element.ID;
            task.TaskTitle = userTask.TaskTitle;
            AntApi.DB.WfTasks.Add(task);
        }

        /// <summary>
        /// 创建任务
        /// </summary>
        /// <param name="context"></param>
        public override void Execute(BpmContext context)
        {
        }

        /// <summary>
        /// 离开该节点
        /// </summary>
        /// <param name="context"></param>
        public override void Leave(BpmContext context)
        {
            next.FindNextLines(context, false);
        }
    }
}
