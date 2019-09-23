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
            CreateMap<Image, ImageDto>();
            CreateMap<ImageDto, Image>();
            CreateMap<GeoCoordinateDto, GeoCoordinate>();
            CreateMap<GeoCoordinate, GeoCoordinateDto>();
            CreateMap<Location, LocationDto>();
            CreateMap<LocationDto, Location>();
            CreateMap<Price, PriceDto>();
            CreateMap<PriceDto, Price>();
            CreateMap<HolidayType, HolidayTypeDto>();
            CreateMap<HolidayTypeDto, HolidayType>();
            CreateMap<HolidayDto, Holiday>();
            CreateMap<Holiday, HolidayDto>();
        }
    }
}
