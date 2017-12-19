using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ant.Entity.Esse;

namespace Ant.Service
{
    public class AuthService
    {
        #region 属性
        private User _currentUser;

        public User CurrentUser { get; set; }
        #endregion
    }
}
