using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_Project.Repository.Database;
using Demo_Project.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Demo_Project.Repository
{
    public class EFTripsReqRepository : ITripsReqRepository
    {
        private readonly bustripsEventsContext _dbContext;

        public EFTripsReqRepository()
        {
            //_dbContext = dbContext;
            _dbContext = new bustripsEventsContext();
        }

        public async Task<List<Tripsreq>> GetAsync()
        {
            return await _dbContext.Tripsreqs.AsNoTracking().ToListAsync();
        }
        public async Task<Tripsreq> GetByIdAsync(int Tripsreqnum)
        {
            return await _dbContext.Tripsreqs.AsNoTracking().FirstOrDefaultAsync(x => x.Tripnum == Tripsreqnum);
        }
        public async Task<Tripsreq> AddAsync(Tripsreq tripsreq)
        {
            _dbContext.Add(tripsreq);
            await _dbContext.SaveChangesAsync();
            return tripsreq;
        }
        public async Task<int> UpdateAsync(Tripsreq tripsreq)
        {
            var TripsreqToUpdate = await _dbContext.Tripsreqs.Where(x => x.Tripnum == tripsreq.Tripnum)
                                                    .FirstOrDefaultAsync();

            return await _dbContext.SaveChangesAsync();
        }
        public async Task<int> DeleteAsync(int TripsReqnum)
        {
            var TripsReqToDelete = await _dbContext.Tripsreqs
                .Where(x => x.Tripnum == TripsReqnum)
                .FirstOrDefaultAsync();

            _dbContext.Remove(TripsReqToDelete);
            return await _dbContext.SaveChangesAsync();
        }

        //public Task<Tripsreq> GetByIdAsync(Guid customersID)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<int> DeleteAsync(Guid TripsReqNum)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
