using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_Project.Repository.Database;
using Demo_Project.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Demo_Project.Repository
{
    public class EFGradeRepository : IGradeRepository
    {
        private readonly bustripsEventsContext _dbContext;

        public EFGradeRepository()
        {
            //_dbContext = dbContext;
            _dbContext = new bustripsEventsContext();
        }

        public async Task<List<Grade>> GetAsync()
        {
            return await _dbContext.Grades.AsNoTracking().ToListAsync();
        }
        public async Task<Grade> GetByIdAsync(string Gradenum)
        {
            return await _dbContext.Grades.AsNoTracking().FirstOrDefaultAsync(x => x.Grade1 == Gradenum);
        }
        public async Task<Grade> AddAsync(Grade grade)
        {
            _dbContext.Add(grade);
            await _dbContext.SaveChangesAsync();
            return grade;
        }
        public async Task<int> UpdateAsync(Grade grade)
        {
            var TripToUpdate = await _dbContext.Grades.Where(x => x.Grade1 == grade.Grade1)
                                                    .FirstOrDefaultAsync();

            return await _dbContext.SaveChangesAsync();
        }
        public async Task<int> DeleteAsync(string Gradenum)
        {
            var TripToDelete = await _dbContext.Grades
     .Where(x => x.Grade1 == Gradenum)
     .FirstOrDefaultAsync();

            _dbContext.Remove(TripToDelete);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
