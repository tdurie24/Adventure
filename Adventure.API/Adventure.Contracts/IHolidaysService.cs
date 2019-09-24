using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Adventure.Contracts.Models;

namespace Adventure.Contracts
{
    public interface IHolidaysService
    {
        Task<List<HolidayDto>> GetHolidaysAsync();

        Task<List<HolidayDto>> GetFeaturedHolidaysAsync();

        Task<List<HolidayDto>> GetHolidaysAsync(LocationDto locationDto);

        Task<HolidayDto> GetHolidayAsync(Guid id);
        Task<string> CreateHolidayAsync(HolidayDto holiday);
        Task UpdateHolidayAsync(HolidayDto holiday);
        Task DeleteHolidayAsync(Guid id);

    }
}
