using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Migrations
{
	/// <inheritdoc />
	public partial class ToltoelementodaCommenti : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_Commenti_Post_PostId",
				table: "Commenti");

			migrationBuilder.DropIndex(
				name: "IX_Commenti_PostId",
				table: "Commenti");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateIndex(
				name: "IX_Commenti_PostId",
				table: "Commenti",
				column: "PostId");

			migrationBuilder.AddForeignKey(
				name: "FK_Commenti_Post_PostId",
				table: "Commenti",
				column: "PostId",
				principalTable: "Post",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);
		}
	}
}
