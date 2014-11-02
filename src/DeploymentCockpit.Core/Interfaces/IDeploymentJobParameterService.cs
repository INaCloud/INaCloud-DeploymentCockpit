﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeploymentCockpit.ApiDtos;
using DeploymentCockpit.Models;

namespace DeploymentCockpit.Interfaces
{
    public interface IDeploymentJobParameterService : ICrudService<DeploymentJobParameter>
    {
        IEnumerable<DeploymentJobParameterDto> GetAllForProject(short projectID);
    }
}