using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Adventure.Contracts;
using Adventure.Contracts.Models;
using Adventure.Data;
using Adventure.Domain.Entities;
using AutoMapper;

namespace Adventure.Services
{
    public class EventsService : IEventsServices
    {
        private readonly AdventureDbContext dbContext;
        private readonly IMapper mapper;
        public EventsService(AdventureDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<string> CreateEvent(EventDto e)
        {
            try
            {
                var eventModel = this.mapper.Map<Event>(e);
                await dbContext.Events.AddAsync(eventModel).ConfigureAwait(false);
                await dbContext.SaveChangesAsync().ConfigureAwait(false);
                return e.EventId.ToString();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task<List<EventDto>> GetEvents()
        {
            try
            {
                List<EventDto> eventDtos = new List<EventDto>();
                List<Event> events = dbContext.Events.ToList();
                foreach (var model in this.mapper.Map<List<EventDto>>(events))
                {
                    eventDtos.Add(model);
                }
                return eventDtos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<EventDto> GetEventById(Guid id)
        {
            var eventModel = await dbContext.Events.FindAsync(id).ConfigureAwait(false);
            return this.mapper.Map<EventDto>(eventModel);
        }

        public async Task DeleteEvent(Guid id)
        {
            var eventModel = await dbContext.Events.FindAsync(id).ConfigureAwait(false);
            dbContext.Events.Remove(eventModel);
            await dbContext.SaveChangesAsync().ConfigureAwait(false);
        }


        public Task<EventDto[]> GetEventsByCoordinator(CoordinatorDto coordinator)
        {
            throw new NotImplementedException();
        }

        public Task<EventDto[]> GetEventsByLocation(LocationDto location)
        {
            throw new NotImplementedException();
        }

        public Task<EventDto[]> GetEventsByPrice(PriceDto price)
        {
            throw new NotImplementedException();
        }

        public void UpdateEvent(EventDto e)
        {
            var ev = this.mapper.Map<Event>(e);
            this.dbContext.Events.Update(ev);
            dbContext.SaveChanges();
        }
    }
}
