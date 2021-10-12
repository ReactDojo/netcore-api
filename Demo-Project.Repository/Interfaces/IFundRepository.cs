using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Demo_Project.Repository.Database;

namespace Demo_Project.Repository.Interfaces
{
    public interface IFundRepository
    {
        Task<List<Fund>> GetAsync();
        Task<Fund> GetByIdAsync(string fundID);
        Task<Fund> AddAsync(Fund fund);
        Task<int> UpdateAsync(Fund fund);
        Task<int> DeleteAsync(string fundId);
    }
}
