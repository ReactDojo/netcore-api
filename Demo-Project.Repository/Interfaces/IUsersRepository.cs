using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Demo_Project.Repository.Database;

namespace Demo_Project.Repository.Interfaces
{
    public interface IUsersRepository
    {
        Task<List<User>> GetAsync();
        Task<User> GetByIdAsync(Guid UserId);
        Task<User> AddAsync(User User);
        Task<int> UpdateAsync(User User);
        Task<int> DeleteAsync(Guid UserId);
    }
}
