﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeploymentCockpit.Models;

namespace DeploymentCockpit.Interfaces
{
    public interface IDeploymentPlanParameterService : ICrudService<DeploymentPlanParameter>
    {
        IEnumerable<TDto> GetAllForPlanAs<TDto>(short deploymentPlanID);
    }
}
