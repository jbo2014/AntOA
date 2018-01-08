using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ant.Enact.Activity
{
    /// <summary>
    /// 手工任务
    /// </summary>
    class ManualTask
    {
        /// <summary>
        /// 经过手工任务时：是否需要办理人确认后再转交下一步，false.不需要自动转交下一步；1.true
        /// </summary>
        public bool needConfirm;
    }
}
