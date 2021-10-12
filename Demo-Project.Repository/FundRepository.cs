using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_Project.Repository.Database;
using Demo_Project.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Demo_Project.Repository
{
    public class EFFundRepository : IFundRepository
    {
        private readonly bustripsEventsContext _dbContext;

        public EFFundRepository()
        {
            //_dbContext = dbContext;
            _dbContext = new bustripsEventsContext();
        }

        public async Task<List<Fund>> GetAsync()
        {
            return await _dbContext.Funds.AsNoTracking().ToListAsync();
        }
        public async Task<Fund> GetByIdAsync(string Fundnum)
        {
            return await _dbContext.Funds.AsNoTracking().FirstOrDefaultAsync(x => x.Fund1 == Fundnum);
        }
        public async Task<Fund> AddAsync(Fund fund)
        {
            _dbContext.Add(fund);
            await _dbContext.SaveChangesAsync();
            return fund;
        }
        public async Task<int> UpdateAsync(Fund fund)
        {
            var TripToUpdate = await _dbContext.Funds.Where(x => x.Fund1 == fund.Fund1)
                                                    .FirstOrDefaultAsync();

            return await _dbContext.SaveChangesAsync();
        }
        public async Task<int> DeleteAsync(string Fundnum)
        {
            var TripToDelete = await _dbContext.Funds
     .Where(x => x.Fund1 == Fundnum)
     .FirstOrDefaultAsync();

            _dbContext.Remove(TripToDelete);
            return await _dbContext.SaveChangesAsync();
        }

        public Task<Trip> GetByIdAsync(Guid tripID)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Guid tripId)
        {
            throw new NotImplementedException();
        }
    }
}
