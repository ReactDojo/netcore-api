using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Demo_Project.Repository.Database;
using Demo_Project.Domain.Entities;

namespace Demo_Project.Services.Interfaces
{
    public interface IProjectService
    {
        Task<List<ProjectEntity>> GetAsync();
        //Task<ProjectEntity> GetByIdAsync(Guid taskId);
        //Task<ProjectEntity> AddAsync(Project task);
        //Task<int> UpdateAsync(Project task);
        //Task<int> DeleteAsync(Guid taskId);
    }
}
