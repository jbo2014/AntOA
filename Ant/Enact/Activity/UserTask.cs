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
        public override void TakeToken(BpmContext context)
        {
            Context = context;
            Execute(Context);

            logger.Info("获取Token" + Context.Element.ID);

        }

        public override void Execute(BpmContext context)
        {
            WfTask task = new WfTask();
            ZUserTask userTask = context.Element as ZUserTask;

            task.TaskGuid = Guid.NewGuid();
            task.InstanceGuid = context.InstanceID;
            task.NodeGuid = userTask.ID;
            task.TaskTitle = userTask.TaskTitle;
            AntApi.DB.WfTasks.Add(task);
        }
    }
}
