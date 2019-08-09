using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Adventure.Contracts;
using Adventure.Contracts.Models;
using Microsoft.AspNetCore.Mvc;

namespace Adventure.Web.API.Controllers
{


    [Route("events")]
    [ApiController]
    public class EventsController : Controller
    {
        private readonly IEventsServices eventsServices;
        public EventsController(IEventsServices eventsServices)
        {
            this.eventsServices = eventsServices;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] EventDto eventModel)
        {
            try
            {
                if(eventModel == null){
                   return BadRequest();
                }
                var eventID = await this.eventsServices.CreateEvent(eventModel);
                return !string.IsNullOrWhiteSpace(eventID) ? Ok(eventID) : (IActionResult)NotFound();

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
                var events = await this.eventsServices.GetEvents().ConfigureAwait(false);
                return Ok(events);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                var em = await this.eventsServices.GetEventById(id).ConfigureAwait(false);
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
                this.eventsServices.DeleteEvent(id);
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