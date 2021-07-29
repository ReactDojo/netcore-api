using Microsoft.AspNetCore.Mvc;
using Demo_Project.Services;
using Demo_Project.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_Project.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : ControllerBase
    {
        public async Task<ActionResult> IndexAsync()
        {
            ProjectService objProjectService = new ProjectService();
            IProjectService projectService;
            projectService = objProjectService;

            var projects = await projectService.GetAsync();

            return Ok(projects);
        }

        // GET: ProjectController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: ProjectController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: ProjectController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(IndexAsync));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ProjectController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: ProjectController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(IndexAsync));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ProjectController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: ProjectController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(IndexAsync));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
