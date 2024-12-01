using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyAspNetProject.Data;
using MyAspNetProject.Models;

namespace MyAspNetProject.Controllers;

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
}
