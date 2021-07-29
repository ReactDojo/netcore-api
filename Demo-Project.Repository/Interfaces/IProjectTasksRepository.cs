using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Demo_Project.Repository.Database;


namespace Demo_Project.Repository.Interfaces
{
    public interface IProjectTasksRepository
    {
        Task<List<ProjectTask>> GetAsync();
        Task<ProjectTask> GetByIdAsync(Guid taskId);
        Task<ProjectTask> AddAsync(ProjectTask task);
        Task<int> UpdateAsync(ProjectTask task);
        Task<int> DeleteAsync(Guid taskId);
    }
}
