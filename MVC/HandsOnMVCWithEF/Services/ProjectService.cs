using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCWithEF.Entities;
namespace HandsOnMVCWithEF.Services
{
    public class ProjectService
    {
        private readonly RMSDBContext context;

        public ProjectService(RMSDBContext context)
        {
            this.context = context;
        }

        //public ProjectService()
        //{
        //    this.context = new RMSDBContext();
        //}
        public void AddProject(Project project)
        {
            this.context.Projects.Add(project); //add new project details to the table
            this.context.SaveChanges();
        }
        public List<Project> GetProjects()
        {
            return context.Projects.ToList();
        }
    }
}
