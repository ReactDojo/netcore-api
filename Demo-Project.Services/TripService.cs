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
    public class TripService : DTO, ITripService
    {
        public ITripsRepository _TripsRepository;

        public TripService()
        {
            projectmanagementContext context = new projectmanagementContext();

            _TripsRepository = new EFTripsRepository();

            //EFProjectRepository objProject = new EFProjectRepository(context);
            //projectRepo = objProject;
        }

        public async Task<List<TripEntity>> GetAsync()
        {
            //throw new Exception("error in the service");
            //AutoMapper.IMapperBase id = new Mapper();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Trip, TripEntity>());
            var mapper = config.CreateMapper();

            var tripRepo = await _TripsRepository.GetAsync();
            //this could essentially just be a list
            var taskTripEntity = mapper.Map<List<TripEntity>>(tripRepo);

            return taskTripEntity;
        }

        public async Task<TripEntity> GetByIdAsync(int TripId)
        {
            //Task<Project> project = new Task<Project>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Trip, TripEntity>());
            var mapper = config.CreateMapper();

            var tripRepo = await _TripsRepository.GetByIdAsync(TripId);
            var taskTripEntity = mapper.Map<TripEntity>(tripRepo);


            return taskTripEntity;
        }

        public async void AddAsync(TripEntity tripEntity)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TripEntity, Trip>());
            var mapper = config.CreateMapper();

            var taskTripDatabase = mapper.Map<Trip>(tripEntity);
            var tripRepo = await _TripsRepository.AddAsync(taskTripDatabase);

            //give a success response for a return, maybe an http 200
            return;
        }

        public async Task<string> UpdateAsync(Trip trip)
        {

            var result = await _TripsRepository.UpdateAsync(trip);

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
