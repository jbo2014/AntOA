using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using Ant.Entity.Esse;

namespace Ant.Service
{
    public abstract class BaseService
    {
        //public SQLDB db { get { return new SQLDB(); } }
        public SQLDB db = new SQLDB();

        /// <summary>
        /// 上下文
        /// </summary>
        public BpmContext Context { get; set; }

        public BaseService() 
        {
            this.Context = new BpmContext();
        }

    }
}
