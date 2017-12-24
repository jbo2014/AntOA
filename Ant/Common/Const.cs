using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Ant.Common
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlowConst
    {
        [Description("流程发起人")]
        Originator = 1,     

        [Description("发起人的部门经理")]
        OriginatorManager = 2,     //需要读department表，找到部门经理

        [Description("发起人的部门主管领导")]
        OriginatorLeader = 3,     //需要读department表，找到部门主管领导
    }
}
