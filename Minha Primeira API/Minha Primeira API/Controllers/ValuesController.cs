using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Minha_Primeira_API.Entities;
using Minha_Primeira_API.Persistence;

namespace Minha_Primeira_API.Controllers
{
    [Route("api/Dev-Events")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DevEventsdbContext _context;
        public ValuesController(DevEventsdbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var devEvents = _context.DevEvents.Where(d => !d.IsDeleted).ToList();
            return Ok(devEvents);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var devEvents = _context.DevEvents.SingleOrDefault(d => d.Id == id);
            if (devEvents == null)
            {
                return NotFound();
            }
            return Ok(devEvents);
        }
        [HttpPost]
        public IActionResult Post(DevEvents devEvents)
        {
            _context.DevEvents.Add(devEvents);
            return CreatedAtAction(nameof(GetById), new { id = devEvents.Id }, devEvents);
        }
        //API/Dev-Events
        [HttpPut("{id}")]
        public IActionResult Update(Guid id, DevEvents input)
        {
            var devEvents = _context.DevEvents.SingleOrDefault(d => d.Id == id);
            if (devEvents == null)
            {
                return NotFound();
            }
            devEvents.Update(input.Title, input.Description, input.StartDate, input.EndDate);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {

            var devEvents = _context.DevEvents.SingleOrDefault(d => d.Id == id);

            if (devEvents == null)
            {
                return NotFound();
            }
            devEvents.Delete();

            return NoContent();

        }
    }
}
    
