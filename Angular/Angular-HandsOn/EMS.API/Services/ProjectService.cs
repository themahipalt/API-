using EMS.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMS.API.DBAccess;
namespace EMS.API.Services
{
    public class ProjectService : IProjectService
    {
        private readonly EMSDBContext eMSDBContext;
        public ProjectService()
        {
            this.eMSDBContext = new EMSDBContext();
        }
        public void AddProject(Project project)
        {
            this.eMSDBContext.Projects.Add(project);
            this.eMSDBContext.SaveChanges();
        }
    }
}
