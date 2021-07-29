using System;
using System.Threading.Tasks;
using AutoMapper;
using Grpc.Core;
using Microsoft.Extensions.Logging;

using DemoProject.Web.Protobufs.V1;
using Demo_Project.Services;
using Demo_Project.Services.Interfaces;


namespace DemoProject.Web.Services
{
    public class ProjectGrpService : Projector.ProjectorBase
    {
        private readonly ILogger<ProjectService> _logger;
        private readonly IMapper _mapper;
        private readonly IProjectService _projectService;

        public ProjectGrpService(ILogger<ProjectService> logger, IMapper mapper, IProjectService projectService)
        {
            _logger = logger;
            _mapper = mapper;
            _projectService = projectService;
        }

        public override async Task GetAllStreamed(EmptyRequest request, IServerStreamWriter<ProjectReply> responseStream, ServerCallContext context)
        {
            var projects = await _projectService.GetAsync();

                foreach (var project in  projects)
                {
                    try
                    { 
                        await responseStream.WriteAsync(_mapper.Map<ProjectReply>(project));
                    }
                    catch(Exception ex)
                    {
                        _logger.LogError(ex.Message);
                    }
                }
                
                var headers = context.GetHttpContext().Request.Headers;
      
            await Task.CompletedTask;
        }
    }
}
