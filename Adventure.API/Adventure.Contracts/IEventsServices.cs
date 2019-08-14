using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Adventure.Contracts.Models;

namespace Adventure.Contracts
{
    public interface IEventsServices
    {
        Task<List<EventDto>> GetEvents();
        Task<EventDto[]> GetEventsByLocation(LocationDto location);
        Task<EventDto[]> GetEventsByCoordinator(CoordinatorDto coordinator);
        Task<EventDto[]> GetEventsByPrice(PriceDto price);
        Task<EventDto> GetEventById(Guid id);
        Task<string> CreateEvent(EventDto e);
        void UpdateEvent(EventDto e);
        Task DeleteEvent(Guid id);
    }
}
