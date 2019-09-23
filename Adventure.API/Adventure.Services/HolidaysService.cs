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
using Microsoft.EntityFrameworkCore;

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

        public async Task<string> CreateHolidayAsync(HolidayDto holiday)
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

        public async Task DeleteHolidayAsync(Guid id)
        {
            var holiday = await dbContext.Holidays.FindAsync(id).ConfigureAwait(false);
            dbContext.Holidays.Remove(holiday);
            await dbContext.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<HolidayDto> GetHolidayAsync(Guid id)
        {
            var holiday = await dbContext.Holidays.FindAsync(id).ConfigureAwait(false);
            return this.mapper.Map<HolidayDto>(holiday);
        }

        public async Task<List<HolidayDto>> GetHolidaysAsync()
        {
            try
            {
               var holidayDtos = new List<HolidayDto>();
               var holidays = await dbContext.Holidays.Include(i=> i.Images).Include(l=> l.Location).Include(p=> p.Price).Include(h=>h.HolidayType).ToListAsync().ConfigureAwait(false);
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

        public async Task<List<HolidayDto>> GetHolidaysAsync(LocationDto locationDto)
        {
            try
            {
                var holidayDtos = new List<HolidayDto>();
                var holidays = await dbContext.Holidays.ToListAsync().ConfigureAwait(false);
                var holidaysByLocation = holidays.Where(x => x.Location == this.mapper.Map<Location>(locationDto));
                foreach (var model in this.mapper.Map<List<HolidayDto>>(holidaysByLocation))
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

        public async Task UpdateHolidayAsync(HolidayDto holiday)
        {
            try
            {
                var h = this.mapper.Map<Holiday>(holiday);
                this.dbContext.Holidays.Update(h);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
          
        }
        
    }
}
