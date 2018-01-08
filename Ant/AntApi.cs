using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Ant.Enact;
using Ant.Service;
using Ant.Entity.Esse;

namespace Ant
{
    /// <summary>
    /// 外部调用的统一入口，可通过它获取其他接口
    /// </summary>
    public class AntApi
    {
        #region 属性
        private static EnactService _enactor;
        private static RuntimeService _runtimeService;
        private static ProcessService _processService;
        private static TaskService _taskService;
        private static AuthService _authService;
        private static FormService _formService;
        private static ManageService _manageService;
        //private static DbService _db;
        private static SQLDB _db = new SQLDB();
        private static readonly object syn = new object();

        public static EnactService Enactor
        {
            get
            {
                //if (_enactor == null)
                //{
                //    lock (syn)
                //    {
                //        if (_enactor == null)
                //        {
                //            _enactor = new EnactService();
                //        }
                //    }
                //}
                //return _enactor;
                return new EnactService();
            }
        }

        public static RuntimeService Runtime
        {
            get
            {
                //if (_runtimeService == null)
                //{
                //    lock (syn)
                //    {
                //        if (_runtimeService == null)
                //        {
                //            _runtimeService = new RuntimeService();
                //        }
                //    }
                //}
                //return _runtimeService;
                return new RuntimeService();
            }
        }

        public static ProcessService Process
        {
            get
            {
                //if (_processService == null)
                //{
                //    lock (syn)
                //    {
                //        if (_processService == null)
                //        {
                //            _processService = new ProcessService();
                //        }
                //    }
                //}
                //return _processService;
                return new ProcessService();
            }
        }

        public static TaskService Tasker
        {
            get
            {
                //if (_taskService == null)
                //{
                //    lock (syn)
                //    {
                //        if (_taskService == null)
                //        {
                //            _taskService = new TaskService();
                //        }
                //    }
                //}
                //return _taskService;
                return new TaskService();
            }
        }

        public static AuthService Auth
        {
            get
            {
                if (_authService == null)
                {
                    lock (syn)
                    {
                        if (_authService == null)
                        {
                            _authService = new AuthService();
                        }
                    }
                }
                return _authService;
            }
        }

        public static FormService Former
        {
            get
            {
                //if (_formService == null)
                //{
                //    lock (syn)
                //    {
                //        if (_formService == null)
                //        {
                //            _formService = new FormService();
                //        }
                //    }
                //}
                //return _formService;
                return new FormService();
            }
        }

        public static ManageService Manager
        {
            get
            {
            //    if (_manageService == null)
            //    {
            //        lock (syn)
            //        {
            //            if (_manageService == null)
            //            {
            //                _manageService = new ManageService();
            //            }
            //        }
            //    }
            //    return _manageService;                
                return new ManageService();
            }
        }

        public static SQLDB DB
        {
            get
            {
                //if (_db == null)
                //{
                //    lock (syn)
                //    {
                //        if (_db == null)
                //        {
                //            _db = new SQLDB();
                //        }
                //    }
                //}
                //return _db;
                return _db;
            }
        }

        public static BpmContext Context { get; set; }
        #endregion

        #region 方法

        #region 字段处理
        #endregion

        #endregion
    }
}
