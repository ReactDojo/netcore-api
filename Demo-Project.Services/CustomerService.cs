using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Text;
using AutoMapper;

using Demo_Project.Repository;
using Demo_Project.Repository.Interfaces;
using Demo_Project.Repository.Database;
using Demo_Project.Services.Interfaces;
using System.Threading.Tasks;

namespace Demo_Project.Services
{
    public class CustomerService: DTO, ICustomerService
    {
        public ICustomersRepository _CustomerRepository;
        private readonly ILogger<EFCustomersRepository> _logger;

        public CustomerService(ILogger<EFCustomersRepository> logger)
        {
            _logger = logger;
            _CustomerRepository = new EFCustomersRepository();
        }


        public async Task<List<CustomerEntity>> GetAsync()
        {
            try
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer, CustomerEntity>());
                var mapper = config.CreateMapper();

                var customerRepo = await _CustomerRepository.GetAsync();
                var customerEntity = mapper.Map<List<CustomerEntity>>(customerRepo);

                return customerEntity;
            } 
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return null;
            }
        }
    }
}
