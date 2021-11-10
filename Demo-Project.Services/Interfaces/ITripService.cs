using Demo_Project.Repository.Database;
using Demo_Project.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo_Project.Services
{
    public interface ITripService
    {
        void AddAsync(TripEntity tripEntity);
        Task<List<TripEntity>> GetAsync();
        Task<TripEntity> GetByIdAsync(int TripId);
        Task<string> UpdateAsync(Trip trip);
    }
}