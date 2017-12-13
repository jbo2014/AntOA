using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public IEnactService Enactor { get; set; }

        public RuntimeService RuntimeService { get; set; }

        public ProcessService ProcessService { get; set; }

        public TaskService TaskService { get; set; }
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
