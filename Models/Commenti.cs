namespace Blog.Models
{
	public class Commenti
	{
		public Guid Id { get; set; }
		public string? Testo { get; set; }
		public string? Autore { get; set; }
		public DateTime Data { get; set; }
		public Guid PostId { get; set; }
	}
}
