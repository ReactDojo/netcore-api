using System;
using Demo_Project.Services.Interfaces;
using Demo_Project.Services;
using Demo_Project.Domain.Entities;

namespace ConsoleAppGrpc
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ProjectService objProjectService = new ProjectService();
            IProjectService projectService;
            projectService = objProjectService;

            var projects = await projectService.GetAsync();

           // projectService = objProj;

        }
    }
}
