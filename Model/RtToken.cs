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
    public partial class RtToken
    {
        [Key]
        public Guid TokenGuid { get; set; }
 
        [DisplayName("所属实例")]
        public Guid InstanceGuid { get; set; }

        [DisplayName("父token")]
        public Guid PreToken { get; set; }
 
        //[DisplayName("父Token")]
        //public Nullable<Guid> ParentToken { get; set; }
 
        [DisplayName("流程定义中的元素Guid")]
        public string ElementID { get; set; }
 
        [DisplayName("状态：0.等待；1.激活；2.消耗完")]
        public Nullable<byte> Status { get; set; }
 
        [DisplayName("创建时间")]
        public Nullable<DateTime> CreateTime { get; set; }
 
        [DisplayName("更新时间")]
        public Nullable<DateTime> UpdateTime { get; set; }

        public virtual RtInstance InstanceGuid_FK { get; set; }
 
    }
}
