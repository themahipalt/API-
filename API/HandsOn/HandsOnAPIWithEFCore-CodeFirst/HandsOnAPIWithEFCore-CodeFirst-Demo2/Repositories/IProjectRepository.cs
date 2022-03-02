using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIWithEFCore_CodeFirst_Demo2.Entities;
namespace HandsOnAPIWithEFCore_CodeFirst_Demo2.Repositories
{
    interface IProjectRepository
    {
        void AddProject(Project project);
    }
}
