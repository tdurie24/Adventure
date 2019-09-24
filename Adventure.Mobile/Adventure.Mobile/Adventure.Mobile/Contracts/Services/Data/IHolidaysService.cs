using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Adventure.Mobile.Models;

namespace Adventure.Mobile.Contracts.Services.Data
{
    public interface IHolidaysService
    {
        Task<List<HolidayModel>> GetHoliday();
    }
}
