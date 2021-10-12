using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Demo_Project.Repository.Database;

namespace Demo_Project.Repository.Interfaces
{
    public interface ITripsRepository
    {
        Task<List<Trip>> GetAsync();
        Task<Trip> GetByIdAsync(int tripID);
        Task<Trip> AddAsync(Trip trip);
        Task<int> UpdateAsync(Trip trip);
        Task<int> DeleteAsync(int tripId);
    }
}
