using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyAspNetProject.Data;

namespace MyAspNetProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YourEntityController : ControllerBase
    {
        private readonly AppDbContext _context;

        public YourEntityController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/YourEntity
        [HttpGet]
        public async Task<ActionResult<IEnumerable<YourEntity>>> GetYourEntities()
        {
            return await _context.YourEntities.ToListAsync();
        }

        // GET: api/YourEntity/5
        [HttpGet("{id}")]
        public async Task<ActionResult<YourEntity>> GetYourEntity(int id)
        {
            var yourEntity = await _context.YourEntities.FindAsync(id);

            if (yourEntity == null)
            {
                return NotFound();
            }

            return yourEntity;
        }

        // PUT: api/YourEntity/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutYourEntity(int id, YourEntity yourEntity)
        {
            if (id != yourEntity.Id)
            {
                return BadRequest();
            }

            _context.Entry(yourEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!YourEntityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/YourEntity
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<YourEntity>> PostYourEntity(YourEntity yourEntity)
        {
            _context.YourEntities.Add(yourEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetYourEntity", new { id = yourEntity.Id }, yourEntity);
        }

        // DELETE: api/YourEntity/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteYourEntity(int id)
        {
            var yourEntity = await _context.YourEntities.FindAsync(id);
            if (yourEntity == null)
            {
                return NotFound();
            }

            _context.YourEntities.Remove(yourEntity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool YourEntityExists(int id)
        {
            return _context.YourEntities.Any(e => e.Id == id);
        }
    }
}
