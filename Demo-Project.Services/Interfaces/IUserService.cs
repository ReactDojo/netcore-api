using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Demo_Project.Repository.Database;

namespace Demo_Project.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<User>> GetAsync();
        Task<User> GetByIdAsync(Guid taskId);
        Task<User> AddAsync(User task);
        Task<int> UpdateAsync(User task);
        Task<int> DeleteAsync(Guid taskId);
    }
}
