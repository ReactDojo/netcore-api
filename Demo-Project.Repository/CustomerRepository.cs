using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_Project.Repository.Database;
using Demo_Project.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Demo_Project.Repository
{
    public class EFCustomersRepository : ICustomersRepository
    {
        private readonly bustripsEventsContext _dbContext;

        public EFCustomersRepository()
        {
            //_dbContext = dbContext;
            _dbContext = new bustripsEventsContext();
        }

        public async Task<List<Customer>> GetAsync()
        {
            return await _dbContext.Customers.AsNoTracking().ToListAsync();
        }
        public async Task<Customer> GetByIdAsync(string Customersnum)
        {
            return await _dbContext.Customers.AsNoTracking().FirstOrDefaultAsync(x => x.Customer1 == Customersnum);
        }
        public async Task<Customer> AddAsync(Customer customers)
        {
            _dbContext.Add(customers);
            await _dbContext.SaveChangesAsync();
            return customers;
        }
        public async Task<int> UpdateAsync(Customer customers)
        {
            var CustomersToUpdate = await _dbContext.Customers.Where(x => x.Customer1 == customers.Customer1)
                                                    .FirstOrDefaultAsync();

            return await _dbContext.SaveChangesAsync();
        }
        public async Task<int> DeleteAsync(string Customersnum)
        {
            var CustomersToDelete = await _dbContext.Customers
     .Where(x => x.Customer1 == Customersnum)
     .FirstOrDefaultAsync();

            _dbContext.Remove(CustomersToDelete);
            return await _dbContext.SaveChangesAsync();
        }

        public Task<Customer> GetByIdAsync(Guid customersID)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Guid customersId)
        {
            throw new NotImplementedException();
        }
    }
}
