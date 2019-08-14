using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventure.Contracts;
using Adventure.Contracts.Models;
using Adventure.Data;
using Adventure.Domain.Entities;
using AutoMapper;

namespace Adventure.Services
{
    public class HolidaysService : IHolidaysService
    {
        private readonly AdventureDbContext dbContext;
        private readonly IMapper mapper;
        public HolidaysService(AdventureDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<string> CreateHoliday(HolidayDto holiday)
        {
            try
            {
                var holidayModel = this.mapper.Map<Holiday>(holiday);
                await dbContext.Holidays.AddAsync(holidayModel).ConfigureAwait(false);
                await dbContext.SaveChangesAsync().ConfigureAwait(false);
                return holiday.Id.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task DeleteHoliday(Guid id)
        {
            var holiday = await dbContext.Holidays.FindAsync(id).ConfigureAwait(false);
            dbContext.Holidays.Remove(holiday);
            await dbContext.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<HolidayDto> GetHoliday(Guid id)
        {
            var holiday = await dbContext.Holidays.FindAsync(id).ConfigureAwait(false);
            return this.mapper.Map<HolidayDto>(holiday);
        }

        public async Task<List<HolidayDto>> GetHolidays()
        {
            try
            {
               var holidayDtos = new List<HolidayDto>();
               var holidays = dbContext.Holidays.ToList();
                foreach (var model in this.mapper.Map<List<HolidayDto>>(holidays))
                {
                    holidayDtos.Add(model);
                }
                return holidayDtos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<List<HolidayDto>> GetHolidays(LocationDto locationDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateHoliday(HolidayDto holiday)
        {
            var h = this.mapper.Map<Holiday>(holiday);
            this.dbContext.Holidays.Update(h);
            dbContext.SaveChanges();
        }
    }
}
