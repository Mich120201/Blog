using Blog.Data;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RisposteController : ControllerBase
	{
		private readonly AppDbContext _context;

		public RisposteController(AppDbContext context)
		{
			_context = context;
		}

		// GET: api/Risposte
		[HttpGet]
		public IActionResult GetRisposte()
		{
			var risposte = _context.Risposte.ToList();
			return Ok(risposte);
		}
		[HttpPost]
		public async Task<ActionResult<Risposte>> PostRisposte(Risposte risposte)
		{
			ModelState.Clear();
			_context.Risposte.Add(risposte);
			_context.SaveChanges();
			return CreatedAtAction("GetRisposteById", new { id = risposte.Id }, risposte);
		}

	}
}
