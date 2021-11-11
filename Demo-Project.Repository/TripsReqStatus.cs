using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_Project.Repository.Database;
using Demo_Project.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Demo_Project.Repository
{
    public class EFTripsReqStatusRepository : ITripsReqStatusRepository
    {
        private readonly bustripsEventsContext _dbContext;

        public EFTripsReqStatusRepository()
        {
            //_dbContext = dbContext;
            _dbContext = new bustripsEventsContext();
        }

        public async Task<List<Tripreqstatus>> GetAsync()
        {
            return await _dbContext.Tripreqstatuses.AsNoTracking().ToListAsync();
        }
        public async Task<Tripreqstatus> GetByIdAsync(string status)
        {
            return await _dbContext.Tripreqstatuses.AsNoTracking().FirstOrDefaultAsync(x => x.Status == status);
        }
        public async Task<Tripreqstatus> AddAsync(Tripreqstatus tripreqStatus)
        {
            _dbContext.Add(tripreqStatus);
            await _dbContext.SaveChangesAsync();
            return tripreqStatus;
        }
        public async Task<int> UpdateAsync(Tripreqstatus tripreqStatus)
        {
            var TripreqstatusToUpdate = await _dbContext.Tripreqstatuses.Where(x => x.Status == tripreqStatus.Status)
                                                    .FirstOrDefaultAsync();

            return await _dbContext.SaveChangesAsync();
        }
     //   public async Task<int> DeleteAsync(int Tripnum)
     //   {
     //       var TripToDelete = await _dbContext.Trips
     //.Where(x => x.Tripnum == Tripnum)
     //.FirstOrDefaultAsync();

     //       _dbContext.Remove(TripToDelete);
     //       return await _dbContext.SaveChangesAsync();
     //   }

     //   public Task<Trip> GetByIdAsync(Guid tripID)
     //   {
     //       throw new NotImplementedException();
     //   }

     //   public Task<int> DeleteAsync(Guid tripId)
     //   {
     //       throw new NotImplementedException();
     //   }
    }
}
