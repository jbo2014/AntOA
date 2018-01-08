using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Ant.Service
{
    public class DbService
    {
        public SQLDB db { get; set; }

        public DbService()
        {
            db = new SQLDB();
        }

        /// <summary>
        /// 创建新Token
        /// </summary>
        public void CreateToken() 
        { }
    }
}
