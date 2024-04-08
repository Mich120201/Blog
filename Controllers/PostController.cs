using Blog.Data;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PostController : ControllerBase
	{
		private readonly AppDbContext _context;

		public PostController(AppDbContext context)
		{
			_context = context;
		}

		// GET: api/Post
		[HttpGet]
		public IActionResult GetPost()
		{
			var post = _context.Post.ToList();
			return Ok(post);
		}
		[HttpPost]
		public async Task<ActionResult<Post>> PostPost(Post post)
		{
			ModelState.Clear();
			_context.Post.Add(post);
			await _context.SaveChangesAsync();
			return CreatedAtAction("GetPostById", new { id = post.Id }, post);
		}
		[HttpGet("{id}")]
		public async Task<ActionResult<Post>> GetPostById(Guid id)
		{
			var post = await _context.Post.FindAsync(id);
			if (post == null)
			{
				return NotFound();
			}
			return post;
		}
		[HttpPut("{id}")]
		public async Task<IActionResult> PutPost(Guid id, Post post)
		{
			if (id != post.Id)
			{
				return BadRequest();
			}
			_context.Entry(post).State = EntityState.Modified;
			try
			{
				await _context.SaveChangesAsync();
				return NoContent();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!PostExists(id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeletePost(Guid id)
		{
			var post = await _context.Post.FindAsync(id);
			if (post == null)
			{
				return NotFound();
			}
			_context.Post.Remove(post);
			await _context.SaveChangesAsync();
			return NoContent();
		}
		private bool PostExists(Guid id)
		{
			return _context.Post.Any(e => e.Id == id);
		}
	}
}
