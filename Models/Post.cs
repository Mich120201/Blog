namespace Blog.Models
{
	public class Post
	{
		public Guid Id { get; set; }
		public string? Title { get; set; }
		public string? Description { get; set; }
		public string? Type { get; set; }
		public string? Url { get; set; }
		public DateTime Data { get; set; }
	}
}
