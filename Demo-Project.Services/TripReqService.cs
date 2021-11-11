using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;

using Demo_Project.Domain.Entities;
using Demo_Project.Repository;
using Demo_Project.Repository.Interfaces;
using Demo_Project.Repository.Database;
using Demo_Project.Services.Interfaces;



namespace Demo_Project.Services
{
    public class TripReqService : DTO, ITripReqService
    {
        public ITripsReqRepository _TripsRepository;

        public TripReqService()
        {
            //projectmanagementContext context = new projectmanagementContext();

            _TripsRepository = new EFTripsReqRepository();

            //EFProjectRepository objProject = new EFProjectRepository(context);
            //projectRepo = objProject;
        }

        public async Task<List<TripsreqEntity>> GetAsync()
        {
            //throw new Exception("error in the service");
            //AutoMapper.IMapperBase id = new Mapper();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Tripsreq, TripsreqEntity>());
            var mapper = config.CreateMapper();

            var tripRepo = await _TripsRepository.GetAsync();
            //this could essentially just be a list
            var taskTripEntity = mapper.Map<List<TripsreqEntity>>(tripRepo);

            return taskTripEntity;
        }

        public async Task<TripsreqEntity> GetByIdAsync(int TripsreqId)
        {
            //Task<Project> project = new Task<Project>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Trip, TripEntity>());
            var mapper = config.CreateMapper();

            var tripRepo = await _TripsRepository.GetByIdAsync(TripsreqId);
            var taskTripEntity = mapper.Map<TripsreqEntity>(tripRepo);


            return taskTripEntity;
        }

        public async Task<TripsreqEntity> AddAsync(TripsreqEntity tripsreqEntity)
        {
            //
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TripsreqEntity, Tripsreq>());
            var mapper = config.CreateMapper();

            var configFrom = new MapperConfiguration(cfg => cfg.CreateMap<Tripsreq, TripsreqEntity>());
            var mapperfrom = config.CreateMapper();

            var taskTripDatabase = mapper.Map<Tripsreq>(tripsreqEntity);
            var tripRepo = await _TripsRepository.AddAsync(taskTripDatabase);

            var tripEnt = mapperfrom.Map<TripsreqEntity>(tripRepo);

            //give a success response for a return, maybe an http 200
            return tripEnt;
        }

        public async Task<string> UpdateAsync(TripsreqEntity tripsreqEntity)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TripsreqEntity, Tripsreq>());
            var mapper = config.CreateMapper();

            var taskTripDatabase = mapper.Map<Tripsreq>(tripsreqEntity);

            var result = await _TripsRepository.UpdateAsync(taskTripDatabase);

            if (result > 0)
            {
                return "";
            }
            else
            {
                //return 0;
                throw new Exception("Update failed");
            }
        }

        //public async Task<bool> DeleteAsync(int ProjectId)
        //{
        //    var result = await _ProjectRepository.DeleteAsync(ProjectId);
        //    if (result > 0)
        //        return true;

        //    throw new Exception("Delete failed");
        //}
    }
}
