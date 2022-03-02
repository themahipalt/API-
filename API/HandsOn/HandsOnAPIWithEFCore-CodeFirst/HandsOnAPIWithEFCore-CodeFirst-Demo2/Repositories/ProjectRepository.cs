using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIWithEFCore_CodeFirst_Demo2.Entities;
using HandsOnAPIWithEFCore_CodeFirst_Demo2.DBAccess;
namespace HandsOnAPIWithEFCore_CodeFirst_Demo2.Repositories
{
    public class ProjectRepository:IProjectRepository
    {
        private readonly HappyDB228Context dbContext;
        public ProjectRepository()
        {
            this.dbContext = new HappyDB228Context();
        }

        public void AddProject(Project project)
        {
            this.dbContext.Projects.Add(project);
            this.dbContext.SaveChanges();
        }
    }
}
