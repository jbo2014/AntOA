using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Field
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public bool IsArray { get; set; }

        /// <summary>
        /// 参数组的名字
        /// </summary>
        public string GroupName { get; set; }

        public string Value { get; set; }
    }
}