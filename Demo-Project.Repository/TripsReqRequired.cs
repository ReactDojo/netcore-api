using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_Project.Repository.Database;
using Demo_Project.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Demo_Project.Repository
{
    public class EFTripsReqRequiredRepository : ITripsReqRequiredRepository
    {
        private readonly bustripsEventsContext _dbContext;

        public EFTripsReqRequiredRepository()
        {
            //_dbContext = dbContext;
            _dbContext = new bustripsEventsContext();
        }

        public async Task<List<TripreqRequired>> GetAsync()
        {
            return await _dbContext.TripreqRequireds.AsNoTracking().ToListAsync();
        }
        public async Task<TripreqRequired> GetByIdAsync(int Tripsreqnum)
        {
            return await _dbContext.TripreqRequireds.AsNoTracking().FirstOrDefaultAsync(x => x.Id == Tripsreqnum);
        }
        public async Task<TripreqRequired> AddAsync(TripreqRequired tripsreq)
        {
            _dbContext.Add(tripsreq);
            await _dbContext.SaveChangesAsync();
            return tripsreq;
        }
        public async Task<int> UpdateAsync(TripreqRequired tripsreq)
        {
            var TripsreqToUpdate = await _dbContext.TripreqRequireds.Where(x => x.Id == tripsreq.Id)
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
