using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    /// <summary>
    /// 文件说明: 信息实体
    /// 作    者: WJB
    /// 生成日期: 2017年12月26日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class FmData
    {
        [Key]
        public Guid FormGuid { get; set; }
 
        [DisplayName("控件ID")]
        public string FormID { get; set; }
 
        public string WidgetID { get; set; }
 
        public string Value { get; set; }
 
    }
}
