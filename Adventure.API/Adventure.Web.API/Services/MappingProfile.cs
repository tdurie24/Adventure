using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Adventure.Contracts.Models;
using Adventure.Domain.Entities;
using AutoMapper;

namespace Adventure.Web.API.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventDto>();
            CreateMap<EventDto, Event>();
            CreateMap<HolidayDto, Holiday>();
            CreateMap<Holiday, HolidayDto>();
        }
    }
}
