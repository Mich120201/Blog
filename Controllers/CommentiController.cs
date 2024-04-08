using Blog.Data;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CommentiController : ControllerBase
	{
		private readonly AppDbContext _context;

		public CommentiController(AppDbContext context)
		{
			_context = context;
		}

		// GET: api/Commenti
		[HttpGet]
		public IActionResult GetCommenti()
		{
			var commenti = _context.Commenti.ToList();
			return Ok(commenti);
		}

		[HttpPost]
		public async Task<ActionResult<Commenti>> PostCommenti(Commenti commenti)
		{
			ModelState.Clear();
			_context.Commenti.Add(commenti);
			await _context.SaveChangesAsync();
			return CreatedAtAction("GetCommentiById", new { id = commenti.Id }, commenti);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Commenti>> GetCommentiById(int id)
		{
			var commenti = await _context.Commenti.FindAsync(id);
			if (commenti == null)
			{
				return NotFound();
			}
			return commenti;
		}

		//      [HttpPut("{id}")]
		//public async Task<IActionResult> PutCommenti(int id, Commenti commenti)
		//      {
		//	if (id != commenti.Id)
		//          {
		//		return BadRequest();
		//	}
		//	_context.Entry(commenti).State = EntityState.Modified;
		//	await _context.SaveChangesAsync();
		//	return NoContent();
		//}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteCommenti(Guid id)
		{
			var commenti = await _context.Commenti.FindAsync(id);
			if (commenti == null)
			{
				return NotFound();
			}
			_context.Commenti.Remove(commenti);
			await _context.SaveChangesAsync();
			return NoContent();
		}
	}
}
