using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Demo_Project.Domain.Entities.Location;
using Demo_Project.Repository.Database;

namespace Demo_Project.Repository.Interfaces
{
    public interface IFileReaderRepository
    {
        Task<RootLocation> ReadAllLinesAsync(string filePath);
    }
}
