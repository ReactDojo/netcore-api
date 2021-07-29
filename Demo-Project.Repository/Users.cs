using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_Project.Repository.Database;
using Demo_Project.Repository.Interfaces;

using Microsoft.EntityFrameworkCore;


namespace Demo_Project.Repository
{
    public class EFUserRepository : IUsersRepository
    {
        private readonly projectmanagementContext _dbContext;
        public EFUserRepository(projectmanagementContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<User>> GetAsync()
        {
            return await _dbContext.Users.AsNoTracking().ToListAsync();
        }

        public async Task<User> GetByIdAsync(Guid UserId)
        {
            return await _dbContext.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Id == UserId);
        }

        public async Task<User> AddAsync(User User)
        {
            _dbContext.Add(User);
            await _dbContext.SaveChangesAsync();
            return User;
        }

        public async Task<int> UpdateAsync(User User)
        {
            var UserToUpdate = await _dbContext.Users.Where(x => x.Id == User.Id)
                                                    .FirstOrDefaultAsync();

            //UserToUpdate.UserName = User.UserName;
            //UserToUpdate.Description = User.Description;

            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(Guid UserId)
        {
            var UserToDelete = await _dbContext.Users
                                                    .Where(x => x.Id == UserId)
                                                    .FirstOrDefaultAsync();

            _dbContext.Remove(UserToDelete);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
