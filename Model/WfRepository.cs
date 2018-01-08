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
    public partial class WfRepository
    {
        public WfRepository()
        {
            this.RtInstance_RepoGuidList = new List<RtInstance>();
            this.WfForm_RepoGuidList = new List<WfForm>();
            this.WfField_RepoGuidList = new List<WfField>();
        }
 
        [Key]
        public Guid RepoGuid { get; set; }
 
        [DisplayName("描述")]
        public string Description { get; set; }
 
        [DisplayName("创建时间")]
        public Nullable<DateTime> CreateTime { get; set; }
 
        [DisplayName("更新时间")]
        public Nullable<DateTime> UpdateTime { get; set; }
 
        [DisplayName("流程定义的版本号")]
        public string Version { get; set; }
 
        [DisplayName("流程定义XML文件的名称")]
        public string BpmFile { get; set; }
 
        [DisplayName("流程定义XML文件的路径")]
        public string BpmPath { get; set; }
 
        [DisplayName("流程定义的XML")]
        public string BpmContent { get; set; }
 
        [DisplayName("流程定义Guid")]
        public Nullable<Guid> ProcessGuid { get; set; }

        public virtual ICollection<RtInstance> RtInstance_RepoGuidList { get; set; }
        public virtual ICollection<WfField> WfField_RepoGuidList { get; set; }
        public virtual ICollection<WfForm> WfForm_RepoGuidList { get; set; }
        public virtual WfProcess ProcessGuid_FK { get; set; }
    }
}
