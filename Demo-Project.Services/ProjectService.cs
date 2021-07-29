using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;

using Demo_Project.Domain.Entities;
using Demo_Project.Repository;
using Demo_Project.Repository.Interfaces;
using Demo_Project.Repository.Database;
using Demo_Project.Services.Interfaces;



namespace Demo_Project.Services
{
    public class ProjectService :  DTO, IProjectService
    {
        public IProjectsRepository _ProjectRepository;

        public ProjectService()
        {
            projectmanagementContext context = new projectmanagementContext();

            _ProjectRepository = new EFProjectRepository();

            //EFProjectRepository objProject = new EFProjectRepository(context);
            //projectRepo = objProject;
        }

        public async Task<List<ProjectEntity>> GetAsync()
        {
            //throw new Exception("error in the service");
            //AutoMapper.IMapperBase id = new Mapper();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Project,ProjectEntity>());
            var mapper = config.CreateMapper();
            
            var projectRepo = await _ProjectRepository.GetAsync();
            //this could essentially just be a list
            var taskProjectEntity = mapper.Map<List<ProjectEntity>>(projectRepo);

            return taskProjectEntity;
        }

        //public async Task<ProjectEntity> GetByIdAsync(Guid ProjectId)
        //{
        //    //Task<Project> project = new Task<Project>();
            
        //    var projectRepo = await _ProjectRepository.GetByIdAsync(ProjectId);
            

        //    return project;
        //}

        //public async Task<ProjectEntity> AddAsync(Project Project)
        //{
        //    return await _ProjectRepository.AddAsync( Project);
        //}

        //public async Task<Project> UpdateAsync(Project Project)
        //{
        //    var result = await _ProjectRepository.UpdateAsync(Project);
        //    if (result > 0)
        //        return Project;

        //    throw new Exception("Update failed");
        //}

        //public async Task<bool> DeleteAsync(int ProjectId)
        //{
        //    var result = await _ProjectRepository.DeleteAsync(ProjectId);
        //    if (result > 0)
        //        return true;

        //    throw new Exception("Delete failed");
        //}
    }
}
