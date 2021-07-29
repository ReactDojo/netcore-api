using System;
using System.Collections.Generic;
using AutoMapper;
using Demo_Project.Domain.Entities;
using DemoProject.Web.Protobufs.V1;
using Google.Protobuf.WellKnownTypes;

namespace DemoProject.Web.Mapping
{
    public class ProjectProfilesV1 : Profile
    {
        public ProjectProfilesV1()
        {
            CreateMap<ProjectEntity, ProjectReply>()
            .ForMember(dest => dest.Id, source => source.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, source => source.MapFrom(src => src.Title))
            .ForMember(dest => dest.Description, source => source.MapFrom(src => src.Notes))
            .ForMember(dest => dest.StartDate, source => source.MapFrom(src => Timestamp.FromDateTime(DateTime.SpecifyKind((DateTime)src.StartDate, DateTimeKind.Utc))))
            .ForMember(dest => dest.EndDate, source => source.MapFrom(src => Timestamp.FromDateTime(DateTime.SpecifyKind((DateTime)src.EndDate, DateTimeKind.Utc))))
            .ForMember(dest => dest.RateOfPay, source => source.MapFrom(src => src.RateOfPay));
            
            CreateMap<IEnumerable<ProjectEntity>, ProjectsReply>()
            .ForMember(dest => dest.Projects, source => source.MapFrom(src => src));

            //CreateMap<CountryCreateRequest, Country>()
            //.ForMember(dest => dest.CountryName, source => source.MapFrom(src => src.Name))
            //.ForMember(dest => dest.Description, source => source.MapFrom(src => src.Description));

            //CreateMap<CountryRequest, Country>()
            //.ForMember(dest => dest.CountryId, source => source.MapFrom(src => src.Id))
            //.ForMember(dest => dest.CountryName, source => source.MapFrom(src => src.Name))
            //.ForMember(dest => dest.Description, source => source.MapFrom(src => src.Description));
        }
    }
}
