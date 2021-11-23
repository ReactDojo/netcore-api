using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Demo_Project.Repository.Database;

namespace Demo_Project.Repository.Interfaces
{
    public interface ITripsReqRequiredRepository
    {
        Task<List<TripreqRequired>> GetAsync();
        Task<TripreqRequired> GetByIdAsync(int tripsReqRequirednum);
        Task<TripreqRequired> AddAsync(TripreqRequired tripsreqRequired);
        Task<int> UpdateAsync(TripreqRequired tripsReqRequired);
        Task<int> DeleteAsync(int tripsReqRequirednum);
    }
}
