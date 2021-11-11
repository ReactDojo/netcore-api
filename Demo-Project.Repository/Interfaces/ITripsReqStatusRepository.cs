using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Demo_Project.Repository.Database;

namespace Demo_Project.Repository
{
    public interface ITripsReqStatusRepository
    {
        Task<List<Tripreqstatus>> GetAsync();
        Task<Tripreqstatus> GetByIdAsync(string status);
        Task<Tripreqstatus> AddAsync(Tripreqstatus tripsreqStatus);
        Task<int> UpdateAsync(Tripreqstatus tripsReqStatus);
       // Task<int> DeleteAsync(string status);
    }
}