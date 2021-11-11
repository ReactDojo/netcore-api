using Demo_Project.Repository.Database;
using Demo_Project.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo_Project.Services
{
    public  interface ITripReqService
    {
        Task<TripsreqEntity> AddAsync(TripsreqEntity tripEntity);
        Task<List<TripsreqEntity>> GetAsync();
        Task<TripsreqEntity> GetByIdAsync(int TripsreqId);
        Task<string> UpdateAsync(TripsreqEntity trip);
    }
}