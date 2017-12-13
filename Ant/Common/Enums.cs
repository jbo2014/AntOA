using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ant.Element
{
    /// <summary>
    /// 流程定义文件的状态
    /// </summary>
    public enum ProcessStatus
    {
        [Description("新建")]
        Created=0,    //新建
            
        [Description("发布")]
        Deploy=1,     //发布
            
        [Description("召回")]
        Revoke=2,     //召回
            
        [Description("删除")]
        Delete=3      //删除
    }

    /// <summary>
    /// 过程实例的状态变迁
    /// </summary>
    public enum InstanceTransitions
    {
        [Description("初始化")]
        Initiated = 0,

        [Description("运行中")]
        Running = 1,

        [Description("激活")]
        Active = 2,             //多用于一个或多个活动

        [Description("挂起")]
        Suspended = 3,

        [Description("结束")]
        Completed = 4,

        [Description("终止")]
        Terminated = 5
    }

}
