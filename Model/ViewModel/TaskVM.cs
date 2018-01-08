using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.ViewModel
{
    public class TaskVM
    {
        public Guid TaskGuid { get; set; }

        public Guid InstanceGuid { get; set; }

        public string InstanceTitle { get; set; }

        public string TaskTitle { get; set; }

        /// <summary>
        /// 流程实例开始时间
        /// </summary>
        public Nullable<DateTime> StartTime { get; set; }

        /// <summary>
        /// 任务创建开始时间
        /// </summary>
        public Nullable<DateTime> CreateTime { get; set; }
    }
}
