using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Demo_Project.Repository.Database;

namespace Demo_Project.Repository.Interfaces
{
    public interface IGradeRepository
    {
        Task<List<Grade>> GetAsync();
        Task<Grade> GetByIdAsync(string gradeID);
        Task<Grade> AddAsync(Grade grade);
        Task<int> UpdateAsync(Grade grade);
        Task<int> DeleteAsync(string gradeId);
    }
}
