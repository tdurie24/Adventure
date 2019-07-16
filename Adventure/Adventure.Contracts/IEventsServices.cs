using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Adventure.Contracts.Models;

namespace Adventure.Contracts
{
    public interface IEventsServices
    {
        Task<Event[]> GetEvents();
        Task<Event[]> GetEventsByLocation(Location location);
        Task<Event[]> GetEventsByCoordinator(Coordinator coordinator);
        Task<Event[]> GetEventsByPrice(Price price);
        Task<Event> GetEventById(Guid id);
        Task CreateEvent(Event e);
        Task UpdateEvent(Event e);
        Task DeleteEvent(Guid id);
    }
}
