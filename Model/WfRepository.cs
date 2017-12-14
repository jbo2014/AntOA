using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    /// <summary>
    /// 文件说明: 信息实体
    /// 作    者: 王俊波
    /// 生成日期: 2017-12-14
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class WfRepository
    {
        public WfRepository()
        {
            			this.WfInstance_RepoGuidList = new List<WfInstance>();
        }

        		[Key]		public Guid RepoGuid { get; set; }		[DisplayName("")]		public Nullable<string> Description { get; set; }		[DisplayName("")]		public DateTime CreateTime { get; set; }		[DisplayName("")]		public Nullable<DateTime> UpdateTime { get; set; }		[DisplayName("描述")]		public Nullable<byte[]> Stamp { get; set; }		[DisplayName("创建时间")]		public Nullable<string> Version { get; set; }		[DisplayName("更新时间")]		public string BpmFile { get; set; }		[DisplayName("时间戳")]		public string BpmPath { get; set; }		[DisplayName("流程定义的版本号")]		public Nullable<string> BpmContent { get; set; }		[DisplayName("流程定义XML文件的名称")]		public Nullable<Guid> ProcessGuid { get; set; } 
        
        		public virtual ICollection<WfInstance> WfInstance_RepoGuidList { get; set; }
    }
}