using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_Project.Repository.Interfaces;
using Demo_Project.Repository.Database;
using Microsoft.EntityFrameworkCore;

namespace Demo_Task.Repository
{
    public class EFTaskRepository : IProjectTasksRepository
    {
        private readonly projectmanagementContext _dbContext;
        public EFTaskRepository(projectmanagementContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ProjectTask>> GetAsync()
        {
            return await _dbContext.ProjectTasks.AsNoTracking().ToListAsync();
        }

        public async Task<ProjectTask> GetByIdAsync(Guid TaskId)
        {
            return await _dbContext.ProjectTasks.AsNoTracking().FirstOrDefaultAsync(x => x.Id == TaskId);
        }

        public async Task<ProjectTask> AddAsync(ProjectTask Task)
        {
            _dbContext.Add(Task);
            await _dbContext.SaveChangesAsync();
            return Task;
        }

        public async Task<int> UpdateAsync(ProjectTask Task)
        {
            var TaskToUpdate = await _dbContext.ProjectTasks.Where(x => x.Id == Task.Id)
                                                    .FirstOrDefaultAsync();

            //TaskToUpdate.TaskName = Task.TaskName;
            //TaskToUpdate.Description = Task.Description;

            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(Guid TaskId)
        {
            var TaskToDelete = await _dbContext.ProjectTasks
                                                    .Where(x => x.Id == TaskId)
                                                    .FirstOrDefaultAsync();

            _dbContext.Remove(TaskToDelete);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
