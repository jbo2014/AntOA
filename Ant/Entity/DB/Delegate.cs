using System;
using System.Collections.Generic;

namespace Ant.Entity.DB
{   
    /// <summary>
    /// 实体-WfDelegate 
    /// </summary>  
	[Table("WfDelegate")]
	public class Delegate
    {    
        public Guid DelegateGuid { get; set; }
          public Guid PrincipalGuid { get; set; }
          public Guid TrusteeGuid { get; set; }
          public Byte DelegateType { get; set; }
          public String ObjectGuids { get; set; }
          public Byte Status { get; set; }
          public DateTime EffectTime { get; set; }
          public DateTime? ExpireTime { get; set; }
    } 
}
