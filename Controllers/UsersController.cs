using Blog.Data;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		private readonly AppDbContext _context;
		public UsersController(AppDbContext context)
		{
			_context = context;
		}

		// GET: api/Users
		[HttpGet]
		public IActionResult GetUsers()
		{
			var users = _context.Users.ToList();
			return Ok(users);
		}

		[HttpGet]
		[Route("GetUserById/{id}")]
		public async Task<ActionResult<Users>> GetUserById(int id)
		{
			var user = await _context.Users.FindAsync(id);
			if (user == null)
			{
				return NotFound();
			}
			return user;
		}

		// POST: api/Users
		[HttpPost]
		public async Task<ActionResult<Users>> PostUser(Users user)
		{
			ModelState.Clear();
			_context.Users.Add(user);
			await _context.SaveChangesAsync();
			return CreatedAtAction("GetUserById", new { id = user.Id }, user);
		}
	}
}
