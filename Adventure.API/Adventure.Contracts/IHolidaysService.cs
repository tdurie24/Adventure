using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Adventure.Contracts.Models;

namespace Adventure.Contracts
{
    public interface IHolidaysService
    {
        Task<List<HolidayDto>> GetHolidays();

        Task<List<HolidayDto>> GetHolidays(LocationDto locationDto);

        Task<HolidayDto> GetHoliday(Guid id);
        Task<string> CreateHoliday(HolidayDto holiday);
        void UpdateHoliday(HolidayDto holiday);
        Task DeleteHoliday(Guid id);

    }
}
