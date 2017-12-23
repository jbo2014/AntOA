using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Ant.Enact;
using Ant.Service;

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
        private static SQLDB _db;
        private static readonly object syn = new object();


        //public static IEnactService GetEnactor()
        //{
        //    if (_enactor == null)
        //    {
        //        lock (syn)
        //        {
        //            if (_enactor == null)
        //            {
        //                _enactor = new EnactService();
        //            }
        //        }
        //    }
        //    return _enactor;
        //}

        //public static RuntimeService GetRuntimeService()
        //{
        //    if (_runtimeService == null)
        //    {
        //        lock (syn)
        //        {
        //            if (_runtimeService == null)
        //            {
        //                _runtimeService = new RuntimeService();
        //            }
        //        }
        //    }
        //    return _runtimeService;
        //}

        //public static ProcessService GetProcessService()
        //{
        //    if (_processService == null)
        //    {
        //        lock (syn)
        //        {
        //            if (_processService == null)
        //            {
        //                _processService = new ProcessService();
        //            }
        //        }
        //    }
        //    return _processService;
        //}

        //public static TaskService GetTaskService()
        //{
        //    if (_taskService == null)
        //    {
        //        lock (syn)
        //        {
        //            if (_taskService == null)
        //            {
        //                _taskService = new TaskService();
        //            }
        //        }
        //    }
        //    return _taskService;
        //}

        public static EnactService Enactor
        {
            get
            {
                if (_enactor == null)
                {
                    lock (syn)
                    {
                        if (_enactor == null)
                        {
                            _enactor = new EnactService();
                        }
                    }
                }
                return _enactor;
            }
        }

        public static RuntimeService Runtime
        {
            get
            {
                if (_runtimeService == null)
                {
                    lock (syn)
                    {
                        if (_runtimeService == null)
                        {
                            _runtimeService = new RuntimeService();
                        }
                    }
                }
                return _runtimeService;
            }
        }

        public static ProcessService Process
        {
            get
            {
                if (_processService == null)
                {
                    lock (syn)
                    {
                        if (_processService == null)
                        {
                            _processService = new ProcessService();
                        }
                    }
                }
                return _processService;
            }
        }

        public static TaskService Tasker
        {
            get
            {
                if (_taskService == null)
                {
                    lock (syn)
                    {
                        if (_taskService == null)
                        {
                            _taskService = new TaskService();
                        }
                    }
                }
                return _taskService;
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

        public static SQLDB DB
        {
            get
            {
                if (_db == null)
                {
                    lock (syn)
                    {
                        if (_db == null)
                        {
                            _db = new SQLDB();
                        }
                    }
                }
                return _db;
            }
        }
        #endregion

        //#region 1.定义转换
        //#endregion

        //#region 2.客户端/用户操作
        ///// <summary>
        ///// 发起/初始化流程，用户打开新流程，点击 保存/取消/转交 等按钮前的处理
        ///// </summary>
        ////public IEnactService Launch()
        ////{}
        ///// <summary>
        ///// 新建流程，第一步点击转交按钮的处理
        ///// </summary>
        ////public IEnactService NewProcess()
        ////{

        ////}
        //public IEnactService 
        //#endregion

        //#region 3.应用调用
        //#endregion

        //#region 4.协调功能
        //#endregion

        //#region 5.管理
        //#endregion
    }
}
