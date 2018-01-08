using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    /// <summary>
    /// 文件说明: 时间内容存储信息实体
    /// 作    者: JBO
    /// 生成日期: 2017年12月30日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class DtFieldDatetime
    {
        [Key]
        public Guid ColumnGuid { get; set; }
 
        [DisplayName("对应流程实例Guid")]
        public Guid InstanceGuid { get; set; }
 
        [DisplayName("列名")]
        public string Name { get; set; }
 
        [DisplayName("列值")]
        public Nullable<DateTime> Value { get; set; }
 
        [DisplayName("列描述")]
        public string Description { get; set; }
 
        [DisplayName("时间格式字符串")]
        public string Format { get; set; }
 
    }
}
