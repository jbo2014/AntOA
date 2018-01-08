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
    public partial class WfForm
    {
        [Key]
        public Guid FormGuid { get; set; }

        [DisplayName("对应流程定义的RepoGuid")]
        public Nullable<Guid> MasterGuid { get; set; }

        [DisplayName("对应流程定义中的TaskPage")]
        public Nullable<Guid> TaskPage { get; set; }

        [DisplayName("类型：起始、任务、共享等类型")]
        public string Type { get; set; }

        [DisplayName("表单名称 ")]
        public string Name { get; set; }

        [DisplayName("表单Html")]
        public string Html { get; set; }

        [DisplayName("创建时间")]
        public Nullable<DateTime> CreateTime { get; set; }

        [DisplayName("创建用户")]
        public Nullable<Guid> CreateUser { get; set; }

        [DisplayName("更新时间")]
        public Nullable<DateTime> UpdateTime { get; set; }

        [DisplayName("更新用户")]
        public Nullable<Guid> UpdateUser { get; set; }

        [DisplayName("修改次数")]
        public Nullable<int> Released { get; set; }

        public virtual WfRepository MasterGuid_FK { get; set; }
 
    }
}
