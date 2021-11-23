using Demo_Project.Repository.Database;
using Demo_Project.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo_Project.Services
{
    public  interface ITripReqRequiredService
    {
        Task<TripsreqRequiredEntity> AddAsync(TripsreqRequiredEntity tripEntity);
        Task<List<TripsreqRequiredEntity>> GetAsync();
        Task<TripsreqRequiredEntity> GetByIdAsync(int TripsreqId);
        Task<string> UpdateAsync(TripsreqRequiredEntity trip);
    }
}