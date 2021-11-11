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
using Demo_Project.Domain.Entities;

namespace Demo_Project.Services
{
    public interface ITripReqStatusService
    {
            //void AddAsync(TripreqstatusEntity tripEntity);
            Task<List<TripreqstatusEntity>> GetAsync();
            //Task<TripreqstatusEntity> GetByIdAsync(int TripId);
            //Task<string> UpdateAsync(Tripreqstatus trip);
    }
}