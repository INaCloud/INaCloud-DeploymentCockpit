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
    
    public partial class TargetGroup
    {
        public TargetGroup()
        {
            this.ProjectTargets = new HashSet<ProjectTarget>();
            this.DeploymentPlanSteps = new HashSet<DeploymentPlanStep>();
        }
    
        public short TargetGroupID { get; set; }
        public short ProjectID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    
        public virtual Project Project { get; set; }
        public virtual ICollection<ProjectTarget> ProjectTargets { get; set; }
        public virtual ICollection<DeploymentPlanStep> DeploymentPlanSteps { get; set; }
    }
}
