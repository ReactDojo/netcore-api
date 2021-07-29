using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Demo_Project.Repository.Database;

namespace Demo_Project.Repository.Interfaces
{
    public interface IProjectsRepository
    {
        Task<List<Project>> GetAsync();
        Task<Project> GetByIdAsync(Guid projectId);
        Task<Project> AddAsync(Project project);
        Task<int> UpdateAsync(Project project);
        Task<int> DeleteAsync(Guid projectId);
    }
}
