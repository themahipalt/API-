using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCWithEF.Models;
using HandsOnMVCWithEF.Entities;
using HandsOnMVCWithEF.Services;
namespace HandsOnMVCWithEF.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ProjectService projectService;

        public ProjectController(ProjectService projectService)
        {
            this.projectService = projectService;
        }

        //public ProjectController()
        //{
        //    this.projectService = new ProjectService();
        //}
        [Route("Project/Add")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [Route("Project/Add")]
        public IActionResult Create(ProjectDTO projectDto)
        {
            if(ModelState.IsValid)
            {
                Project project = new Project()
                {
                    ProjectCode = projectDto.ProjectCode,
                    ProjectName = projectDto.ProjectName
                };
                this.projectService.AddProject(project);
                return RedirectToAction("Create");
            }
            else
            {
                return View();
            }
        }

    }
}
