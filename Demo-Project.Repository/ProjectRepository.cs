using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_Project.Repository.Database;
using Demo_Project.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Demo_Project.Repository
{
    public class EFProjectRepository : IProjectsRepository
    {
        private readonly projectmanagementContext _dbContext;
        public EFProjectRepository()
        {
            //_dbContext = dbContext;
            _dbContext = new projectmanagementContext();
        }

        public async Task<List<Project>> GetAsync()
        {
            return await _dbContext.Projects.AsNoTracking().ToListAsync();
        }

        public async Task<Project> GetByIdAsync(Guid ProjectId)
        {
            return await _dbContext.Projects.AsNoTracking().FirstOrDefaultAsync(x => x.Id == ProjectId);
        }

        public async Task<Project> AddAsync(Project Project)
        {
            _dbContext.Add(Project);
            await _dbContext.SaveChangesAsync();
            return Project;
        }

        public async Task<int> UpdateAsync(Project Project)
        {
            var ProjectToUpdate = await _dbContext.Projects.Where(x => x.Id == Project.Id)
                                                    .FirstOrDefaultAsync();

            //ProjectToUpdate.ProjectName = Project.ProjectName;
            //ProjectToUpdate.Description = Project.Description;

            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(Guid ProjectId)
        {
            var ProjectToDelete = await _dbContext.Projects
                                                    .Where(x => x.Id == ProjectId)
                                                    .FirstOrDefaultAsync();

            _dbContext.Remove(ProjectToDelete);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
