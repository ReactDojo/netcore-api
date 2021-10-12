using System;
using System.Collections.Generic;
using System.Text;
using Demo_Project.Repository.Database;
using System.Threading.Tasks;

namespace Demo_Project.Services.Interfaces
{
    public interface IDestinationService
    { 
        Task<List<DestinationEntity>> GetAsync();
    }
}
