using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIWithEFCore_CodeFirst_Demo2.Repositories;
using HandsOnAPIWithEFCore_CodeFirst_Demo2.Entities;
namespace HandsOnAPIWithEFCore_CodeFirst_Demo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectRepository projectRepository;
        public ProjectController()
        {
            this.projectRepository = new ProjectRepository();
        }
        [HttpPost]
        [Route("AddProject")]
        public IActionResult Add(Project project)
        {
            projectRepository.AddProject(project);
            return StatusCode(200);
        }
    }
}
