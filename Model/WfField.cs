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
    public partial class WfField
    {
        [Key]
        public Guid FieldGuid { get; set; }

        [DisplayName("流程定义RepoGuid")]
        public Guid MasterGuid { get; set; }

        [DisplayName("列名")]
        public string Name { get; set; }

        [DisplayName("别名")]
        public string Alias { get; set; }

        [DisplayName("类型：对应CodeTable中FieldType")]
        public string Type { get; set; }

        [DisplayName("是否是数组")]
        public Nullable<bool> IsArray { get; set; }

        [DisplayName("分组名")]
        public string GroupName { get; set; }

        [DisplayName("格式")]
        public string Format { get; set; }

        [DisplayName("列值")]
        public string Value { get; set; }

        [DisplayName("列描述")]
        public string Description { get; set; }

        public virtual WfRepository MasterGuid_FK { get; set; }
 
    }
}
