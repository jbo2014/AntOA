using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ant.Entity.Exchange
{
    public class User
    {
        public string LoginID { get; set; }

        /// <summary>
        /// 登陆用户姓名
        /// </summary>
        public string Name { get; set; }

        public string DepartmentID { get; set; }

        /// <summary>
        /// 账户涉及的角色列表
        /// </summary>
        public List<string> Role { get; set; }

        /// <summary>
        /// 账户设计的用户组列表
        /// </summary>
        public List<string> GroupID { get; set; }
    }
}
