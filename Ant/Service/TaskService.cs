using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

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
        public WfInstance GetInstanceByTask(Guid TaskGuid) 
        {
            WfTask task = AntApi.DB.WfTasks.First<WfTask>(o => o.TaskGuid == TaskGuid);
            WfInstance instance = AntApi.DB.WfInstances.First<WfInstance>(o => o.InstanceGuid == task.InstanceGuid);
            return instance;
        }
        public WfTask GetTaskByInstance(Guid InstanceGuid)
        {
            WfInstance instance = AntApi.DB.WfInstances.First<WfInstance>(o => o.InstanceGuid == InstanceGuid);
            WfTask task = AntApi.DB.WfTasks.First<WfTask>(o => o.InstanceGuid == instance.InstanceGuid);
            return task;
        }

        /// <summary>
        /// 获取用户对应的任务列表
        /// </summary>
        /// <param name="taskGuid"></param>
        public List<WfTask> GetTaskListByUser(string UserID) 
        {
            List<WfTask> tasks = AntApi.DB.WfTasks.Where(o=>(o.Executor==UserID)||(o.Owner==UserID && string.IsNullOrEmpty(o.Executor))).ToList<WfTask>();
            if (tasks.Count() > 0)
                return tasks;
            return null;
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

        /// <summary>
        /// 获取任务表单
        /// </summary>
        public string GetTaskForm(Guid taskGuid)
        {
            WfTask task = AntApi.DB.WfTasks.First<WfTask>(o => o.TaskGuid == taskGuid);
            if (task != null)
                return task.NodeID;
            return null;
        }

        public void Complete(Guid taskGuid) 
        { }
        #endregion
    }
}
