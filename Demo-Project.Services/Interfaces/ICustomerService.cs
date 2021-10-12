using Demo_Project.Repository.Database;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Project.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<List<CustomerEntity>> GetAsync();
    }
}
