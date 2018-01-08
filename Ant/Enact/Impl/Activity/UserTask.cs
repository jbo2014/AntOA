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
            DateTime dt = DateTime.Now;
            ZUserTask userTask = context.Element as ZUserTask;

            RtActivity activity = new RtActivity();
            activity.ActivityGuid = Guid.NewGuid();
            activity.ActivityID = context.Element.ID;
            activity.TaskPage = new Guid(userTask.TaskPage);
            activity.InstanceGuid = context.InstanceID;
            activity.StartTime = dt;
            AntApi.DB.RtActivitys.Add(activity);
            
            RtTask task = new RtTask();
            task.TaskGuid = Guid.NewGuid();
            task.InstanceGuid = context.InstanceID;
            task.ActivityGuid = activity.ActivityGuid;
            task.TaskTitle = userTask.TaskTitle;
            task.Owner = userTask.Candidates;
            task.CreateTime = dt;
            AntApi.DB.RtTasks.Add(task);

            AntApi.DB.SaveChanges();
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
            FindNextLines(context, false);
        }
    }
}
