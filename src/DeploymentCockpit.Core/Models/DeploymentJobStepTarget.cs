//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeploymentCockpit.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DeploymentJobStepTarget
    {
        public int DeploymentJobStepTargetID { get; set; }
        public int DeploymentJobStepID { get; set; }
        public short TargetID { get; set; }
        public string StatusKey { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public string ExecutedScript { get; set; }
        public string ExecutionOutput { get; set; }
        public System.Guid ExecutionReference { get; set; }
    
        public virtual DeploymentJobStep DeploymentJobStep { get; set; }
        public virtual Target Target { get; set; }
    }
}
