using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ant.Common
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

    public enum ResultEnum
    {
        [Description("未执行")]
        NoExe = 0,

        [Description("执行成功")]
        Success = 1,

        [Description("执行失败")]
        Fail = 2,

        [Description("执行异常")]
        Error = 3
    }

    /// <summary>
    /// 流程决策模式：用于会签节点
    /// </summary>
    public enum DecisionEnum
    {
        //主办人模式：以主办人的办理情况为准
        [Description("主办人模式")]
        Sponsor = 1,

        //投票模式：根据设置的比例通过
        [Description("投票模式")]
        Vote = 2,

        //一票通过：投票模式的变种，一票通过及往下流转
        [Description("一票通过")]
        OnePass = 3,

        //一票否决：投票模式的变种，一票不通过及中断（完全不通过）
        [Description("一票否决")]
        OneVeto = 4
    }

    /// <summary>
    /// 会签流转模式
    /// </summary>
    public enum SignRunEnum
    {
        [Description("并行")]
        Parallel = 0,

        [Description("串行")]
        Serial = 1
    }

    /// <summary>
    /// 会签流转模式
    /// </summary>
    public enum TokenStatus
    {
        [Description("等待中")]
        Waiting = 0,

        [Description("已激活")]
        Actived = 1,

        [Description("已消耗")]
        WorkOut = 2
    }

}
