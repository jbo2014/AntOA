using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    /// <summary>
    /// 文件说明: 信息实体
    /// 作    者: JBO
    /// 生成日期: 2017年12月30日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class CodeTable
    {
        [Key]
        public string CodeCD { get; set; }
 
        [DisplayName("码组")]
        public string Group { get; set; }
 
        [DisplayName("码名")]
        public string Name { get; set; }
 
        [DisplayName("码值")]
        public int Value { get; set; }
 
        [DisplayName("排列顺序")]
        public Nullable<int> Sort { get; set; }
 
        [DisplayName("描述")]
        public string Description { get; set; }
 
    }
}
