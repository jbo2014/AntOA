//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class WfDelegate
    {
        public System.Guid DelegateGuid { get; set; }
        public System.Guid PrincipalGuid { get; set; }
        public System.Guid TrusteeGuid { get; set; }
        public byte DelegateType { get; set; }
        public string ObjectGuids { get; set; }
        public byte Status { get; set; }
        public System.DateTime EffectTime { get; set; }
        public Nullable<System.DateTime> ExpireTime { get; set; }
    }
}