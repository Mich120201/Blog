﻿namespace Blog.Models
{
	public class Users
	{
		public Guid Id { get; set; }
		public string? Name { get; set; }
		public string? PasswordHash { get; set; }
		public string? Email { get; set; }
	}
}
