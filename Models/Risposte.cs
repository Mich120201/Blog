namespace Blog.Models
{
	public class Risposte
	{
		public Guid Id { get; set; }
		public string? Testo { get; set; }
		public string? Autore { get; set; }
		public DateTime Data { get; set; }
		public Guid CommentId { get; set; }
	}
}
