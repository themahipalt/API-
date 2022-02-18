using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMS.API.Entities;
namespace EMS.API.Services
{
    public interface IProjectService
    {
        void AddProject(Project project);
    }
}
