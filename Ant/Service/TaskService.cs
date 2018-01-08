using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.ViewModel;

namespace Ant.Service
{
    /// <summary>
    /// 查询分配给用户或组的任务
    /// 创建独立运行任务。这些任务与流程实例无关。
    /// 手工设置任务的执行者，或者这些用户通过何种方式与任务关联。
    /// 认领并完成一个任务。认领意味着一个人期望成为任务的执行者， 即这个用户会完成这个任务。完成意味着“做这个任务要求的事情”。 通常来说会有很多种处理形式。
    /// </summary>
    public class TaskService
    {
        #region 任务列表
        #endregion

        #region 用户操作
        public RtInstance GetInstanceByTask(Guid TaskGuid) 
        {
            RtTask task = AntApi.DB.RtTasks.First<RtTask>(o => o.TaskGuid == TaskGuid);
            RtInstance instance = AntApi.DB.RtInstances.First<RtInstance>(o => o.InstanceGuid == task.InstanceGuid);
            return instance;
        }
        public RtTask GetFirstTaskByInstance(Guid InstanceGuid)
        {
            RtInstance instance = AntApi.DB.RtInstances.First<RtInstance>(o => o.InstanceGuid == InstanceGuid);
            RtTask task = AntApi.DB.RtTasks.First<RtTask>(o => o.InstanceGuid == instance.InstanceGuid);
            return task;
        }

        /// <summary>
        /// 获取用户对应的任务列表
        /// </summary>
        /// <param name="taskGuid"></param>
        public List<TaskVM> GetTaskListByUser(string UserID) 
        {
            List<TaskVM> taskList = new List<TaskVM>();
            TaskVM taskVM = null;
            List<RtTask> tasks = AntApi.DB.RtTasks.Where(o=>(o.Executor==UserID)||(o.Owner==UserID && string.IsNullOrEmpty(o.Executor))).ToList<RtTask>();
            if (tasks.Count() > 0)
            {
                foreach (RtTask task in tasks) 
                {
                    taskVM = new TaskVM();
                    taskVM.TaskGuid = task.TaskGuid;
                    taskVM.InstanceGuid = task.InstanceGuid;
                    taskVM.TaskTitle = task.TaskTitle;
                    if (task.InstanceGuid_FK != null)
                    {
                        taskVM.InstanceTitle = task.InstanceGuid_FK.InstanceTitle;
                        taskVM.StartTime = task.InstanceGuid_FK.StartTime;
                    }
                    taskVM.CreateTime = task.CreateTime;
                    taskList.Add(taskVM);
                }
                return taskList.OrderByDescending(o=>o.CreateTime.Value).ToList();
            }
            return null;
        }

        /// <summary>
        /// 获取Task
        /// </summary>
        /// <param name="taskGuid"></param>
        /// <returns></returns>
        public RtTask GetTaskByTaskGuid(Guid taskGuid) 
        {
            RtTask task = AntApi.DB.RtTasks.First(o => o.TaskGuid == taskGuid);
            return task;
        }

        /// <summary>
        /// 获取活动实例
        /// </summary>
        /// <returns></returns>
        public RtActivity GetActivityByTaskGuid(Guid taskGuid) 
        {
            RtTask task = AntApi.DB.RtTasks.First(o => o.TaskGuid == taskGuid);
            RtActivity activity = AntApi.DB.RtActivitys.First(o=>o.ActivityGuid == task.ActivityGuid);
            return activity;
        }

        /// <summary>
        /// 获取角色对应的任务列表
        /// </summary>
        /// <param name="taskGuid"></param>
        public void GetTaskListByRole(Guid taskGuid) { }

        /// <summary>
        /// 认领任务
        /// </summary>
        /// <param name="taskGuid"></param>
        /// <param name="UserID">认领任务的用户ID</param>
        public void Claim(Guid taskGuid, string UserID) 
        { }

        /// <summary>
        /// 加签
        /// </summary>
        public void AddSign() 
        { }

        public void Complete(Guid taskGuid) 
        { }
        #endregion
    }
}
