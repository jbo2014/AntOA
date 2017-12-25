using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ant.Entity.Esse;

namespace Ant.Service
{
    /// <summary>
    /// 管理（创建，更新，删除，查询...）群组和用户
    /// </summary>
    public class AuthService
    {
        #region 属性
        private User _currentUser;

        public User CurrentUser { get; set; }

        public AuthService() 
        {
            if(CurrentUser == null)
                CurrentUser = new User();
        }
        #endregion
    }
}
