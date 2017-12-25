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
        /// <summary>
        /// 打开任务表单
        /// </summary>
        /// <param name="taskGuid"></param>
        public void OpenTaskForm(Guid taskGuid) { }

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
        public void GetTaskForm(Guid taskGuid)
        {

        }

        public void Complete(Guid taskGuid) 
        { }
        #endregion
    }
}
