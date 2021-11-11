using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Demo_Project.Repository.Database;

namespace Demo_Project.Repository
{
    public interface ITripsReqRepository
    {
        Task<List<Tripsreq>> GetAsync();
        Task<Tripsreq> GetByIdAsync(int tripsReqnum);
        Task<Tripsreq> AddAsync(Tripsreq tripsreq);
        Task<int> UpdateAsync(Tripsreq tripsReq);
        Task<int> DeleteAsync(int tripsReqnum);
    }
}