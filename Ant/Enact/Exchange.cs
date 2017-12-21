using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ant.Entity.Bpmx;

namespace Ant.Enact
{
    internal interface Exchange
    {
        // 离开节点,this.Take();
        void Leave();

        // 连线获取Token,this.Enter();
        void Take();

        // 进入节点
        void Enter(ZElement element);

    }
}
