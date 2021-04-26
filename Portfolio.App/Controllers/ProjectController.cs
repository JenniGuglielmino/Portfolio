using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portfolio.ApiClient;
using Portfolio.App.Models;
using Portfolio.Dto;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.App.Controllers
{
    public class ProjectController : Controller
    {

        public async Task<IActionResult> Index()
        {
            var list = new List<ProjectDto>();
            var ret = await ProjectProxyMethods.Get();
            if (ret.Count > 0)
            {
                list = ret;
            }
            else
            {
                list.Add(
                    new ProjectDto()
                    {
                        Id = -1,
                        Title = "Error",
                        Description = "No se obtuvieron proyectos desde la base"
                    });
            }
            return View(list);
        }
    }
}
