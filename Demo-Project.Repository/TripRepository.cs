using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_Project.Repository.Database;
using Demo_Project.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Demo_Project.Repository
{
    public class EFTripsRepository : ITripsRepository
    {
        private readonly bustripsEventsContext _dbContext;

        public EFTripsRepository()
        {
            //_dbContext = dbContext;
            _dbContext = new bustripsEventsContext();
        }

        public async Task<List<Trip>> GetAsync()
        {
            return await _dbContext.Trips.AsNoTracking().ToListAsync();
        }
        public async Task<Trip> GetByIdAsync(int Tripnum)
        {
            return await _dbContext.Trips.AsNoTracking().FirstOrDefaultAsync(x => x.Tripnum == Tripnum);
        }
        public async Task<Trip> AddAsync(Trip trip)
        {
            _dbContext.Add(trip);
            await _dbContext.SaveChangesAsync();
            return trip;
        }
        public async Task<int> UpdateAsync(Trip trip)
        {
            var TripToUpdate = await _dbContext.Trips.Where(x => x.Tripnum == trip.Tripnum)
                                                    .FirstOrDefaultAsync();

            return await _dbContext.SaveChangesAsync();
        }
        public async Task<int> DeleteAsync(int Tripnum)
        {
            var TripToDelete = await _dbContext.Trips
     .Where(x => x.Tripnum == Tripnum)
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
