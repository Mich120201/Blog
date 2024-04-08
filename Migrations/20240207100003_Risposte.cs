﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Migrations
{
	/// <inheritdoc />
	public partial class Risposte : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Risposte",
				columns: table => new
				{
					Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
					Testo = table.Column<string>(type: "longtext", nullable: true)
						.Annotation("MySql:CharSet", "utf8mb4"),
					Autore = table.Column<string>(type: "longtext", nullable: true)
						.Annotation("MySql:CharSet", "utf8mb4"),
					Data = table.Column<DateTime>(type: "datetime(6)", nullable: false),
					CommentId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Risposte", x => x.Id);
				})
				.Annotation("MySql:CharSet", "utf8mb4");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Risposte");
		}
	}
}
