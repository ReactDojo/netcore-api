using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Demo_Project.Repository.Database;

namespace Demo_Project.Repository.Interfaces
{
    public interface ICustomersRepository
    {
        Task<List<Customer>> GetAsync();
        Task<Customer> GetByIdAsync(string customerID);
        Task<Customer> AddAsync(Customer customer);
        Task<int> UpdateAsync(Customer customer);
        Task<int> DeleteAsync(string customerID);
    }
}
