using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Adventure.Contracts;
using Adventure.Contracts.Models;
using Microsoft.AspNetCore.Mvc;

namespace Adventure.Web.API.Controllers
{

    [Route("api/holidays")]
    [ApiController]
    public class HolidaysController : Controller
    {
        private readonly IHolidaysService holidaysService;
        public HolidaysController(IHolidaysService holidaysService)
        {
            this.holidaysService = holidaysService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] HolidayDto holiday)
        {
            try
            {
                if (holiday == null)
                {
                    return BadRequest();
                }
                var holidayId = await this.holidaysService.CreateHolidayAsync(holiday);
                return !string.IsNullOrWhiteSpace(holidayId) ? Ok(holidayId) : (IActionResult)NotFound();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var holidays = await this.holidaysService.GetHolidaysAsync().ConfigureAwait(false);
                return Ok(holidays);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        //[HttpGet]
        //public async Task<IActionResult> GetFeaturedHolidays()
        //{
        //    try
        //    {
        //        var holidays = await this.holidaysService.GetFeaturedHolidaysAsync().ConfigureAwait(false);
        //        return Ok(holidays);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //        throw;
        //    }
        //}



        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                var em = await this.holidaysService.GetHolidayAsync(id).ConfigureAwait(false);
                return em != null ? Ok(em) : (IActionResult)NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            try
            {
                this.holidaysService.DeleteHolidayAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }
    }
}