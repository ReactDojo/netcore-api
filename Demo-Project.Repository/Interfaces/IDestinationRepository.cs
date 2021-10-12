using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Demo_Project.Repository.Database;

namespace Demo_Project.Repository.Interfaces
{
    public interface IDestinationRepository
    {
        Task<List<Destination>> GetAsync();
        Task<Destination> GetByIdAsync(int destinationID);
        Task<Destination> AddAsync(Destination destination);
        Task<int> UpdateAsync(Destination destination);
        Task<int> DeleteAsync(int destinationId);
    }
}
