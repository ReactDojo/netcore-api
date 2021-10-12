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

namespace Demo_Project.Services
{
    public class GradeService:DTO, IGradeService
    {
        public IGradeRepository _Repository;
        private readonly ILogger<EFGradeRepository> _logger;

        public GradeService(ILogger<EFGradeRepository> logger)
        {
            _logger = logger;
            _Repository = new EFGradeRepository();
        }


        public async Task<List<GradeEntity>> GetAsync()
        {
            try
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Grade, GradeEntity>());
                var mapper = config.CreateMapper();

                var repo = await _Repository.GetAsync();
                var entity = mapper.Map<List<GradeEntity>>(repo);

                return entity;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return null;
            }
        }
    }
}
