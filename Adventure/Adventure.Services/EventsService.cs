using System;
using System.Threading.Tasks;
using Adventure.Contracts;
using Adventure.Contracts.Models;

namespace Adventure.Services
{
    public class EventsService : IEventsServices
    {
        public Task CreateEvent(Event e)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEvent(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Event> GetEventById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Event[]> GetEvents()
        {
            throw new NotImplementedException();
        }

        public Task<Event[]> GetEventsByCoordinator(Coordinator coordinator)
        {
            throw new NotImplementedException();
        }

        public Task<Event[]> GetEventsByLocation(Location location)
        {
            throw new NotImplementedException();
        }

        public Task<Event[]> GetEventsByPrice(Price price)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEvent(Event e)
        {
            throw new NotImplementedException();
        }
    }
}
