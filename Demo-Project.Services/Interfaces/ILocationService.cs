using Demo_Project.Domain.Entities.Location;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Project.Services.Interfaces
{
    public interface ILocationService
    {
        Task<RootLocationEntity> ReadAllLinesAsync(string filePath);
    }
}
