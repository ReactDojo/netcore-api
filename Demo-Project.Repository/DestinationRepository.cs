using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_Project.Repository.Database;
using Demo_Project.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Demo_Project.Repository
{
    public class EFDestinationRepository : IDestinationRepository
    {
        private readonly bustripsEventsContext _dbContext;

        public EFDestinationRepository()
        {
            //_dbContext = dbContext;
            _dbContext = new bustripsEventsContext();
        }

        public async Task<List<Destination>> GetAsync()
        {
            return await _dbContext.Destinations.AsNoTracking().ToListAsync();
        }
        public async Task<Destination> GetByIdAsync(int destinationNum)
        {
            return await _dbContext.Destinations.AsNoTracking().FirstOrDefaultAsync(x => x.Destination1 == destinationNum);
        }
        public async Task<Destination> AddAsync(Destination trip)
        {
            _dbContext.Add(trip);
            await _dbContext.SaveChangesAsync();
            return trip;
        }
        public async Task<int> UpdateAsync(Destination destination)
        {
            var TripToUpdate = await _dbContext.Destinations.Where(x => x.Destination1 == destination.Destination1)
                                                    .FirstOrDefaultAsync();

            return await _dbContext.SaveChangesAsync();
        }
        public async Task<int> DeleteAsync(int destinationNum)
        {
            var TripToDelete = await _dbContext.Destinations
     .Where(x => x.Destination1 == destinationNum)
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
