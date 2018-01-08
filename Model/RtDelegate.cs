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
    public partial class RtDelegate
    {
        [Key]
        public Guid DelegateGuid { get; set; }
 
        [DisplayName("委托人Guid")]
        public Guid PrincipalGuid { get; set; }
 
        [DisplayName("受托人Guid")]
        public Guid TrusteeGuid { get; set; }
 
        [DisplayName("授权类型：   1.临时委托；   2.实例；   3.流程定义委托；   4.角色委托；   5.完全授权")]
        public byte DelegateType { get; set; }
 
        [DisplayName("0、流程定义、定义节点、实例、实例任务，5种情况的Guid")]
        public string ObjectGuids { get; set; }
 
        [DisplayName("状态")]
        public byte Status { get; set; }
 
        [DisplayName("生效时间")]
        public Nullable<DateTime> EffectTime { get; set; }
 
        [DisplayName("失效时间")]
        public Nullable<DateTime> ExpireTime { get; set; }
 
    }
}
