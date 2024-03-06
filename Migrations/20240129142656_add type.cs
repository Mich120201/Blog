using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Migrations
{
	/// <inheritdoc />
	public partial class addtype : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AlterColumn<string>(
				name: "PasswordHash",
				table: "Users",
				type: "longtext",
				nullable: true,
				oldClrType: typeof(string),
				oldType: "longtext")
				.Annotation("MySql:CharSet", "utf8mb4")
				.OldAnnotation("MySql:CharSet", "utf8mb4");

			migrationBuilder.AlterColumn<string>(
				name: "Name",
				table: "Users",
				type: "longtext",
				nullable: true,
				oldClrType: typeof(string),
				oldType: "longtext")
				.Annotation("MySql:CharSet", "utf8mb4")
				.OldAnnotation("MySql:CharSet", "utf8mb4");

			migrationBuilder.AlterColumn<string>(
				name: "Email",
				table: "Users",
				type: "longtext",
				nullable: true,
				oldClrType: typeof(string),
				oldType: "longtext")
				.Annotation("MySql:CharSet", "utf8mb4")
				.OldAnnotation("MySql:CharSet", "utf8mb4");

			migrationBuilder.AlterColumn<string>(
				name: "Title",
				table: "Post",
				type: "longtext",
				nullable: true,
				oldClrType: typeof(string),
				oldType: "longtext")
				.Annotation("MySql:CharSet", "utf8mb4")
				.OldAnnotation("MySql:CharSet", "utf8mb4");

			migrationBuilder.AlterColumn<string>(
				name: "Description",
				table: "Post",
				type: "longtext",
				nullable: true,
				oldClrType: typeof(string),
				oldType: "longtext")
				.Annotation("MySql:CharSet", "utf8mb4")
				.OldAnnotation("MySql:CharSet", "utf8mb4");

			migrationBuilder.AddColumn<string>(
				name: "Type",
				table: "Post",
				type: "longtext",
				nullable: true)
				.Annotation("MySql:CharSet", "utf8mb4");

			migrationBuilder.AlterColumn<string>(
				name: "Testo",
				table: "Commenti",
				type: "longtext",
				nullable: true,
				oldClrType: typeof(string),
				oldType: "longtext")
				.Annotation("MySql:CharSet", "utf8mb4")
				.OldAnnotation("MySql:CharSet", "utf8mb4");

			migrationBuilder.AlterColumn<string>(
				name: "Autore",
				table: "Commenti",
				type: "longtext",
				nullable: true,
				oldClrType: typeof(string),
				oldType: "longtext")
				.Annotation("MySql:CharSet", "utf8mb4")
				.OldAnnotation("MySql:CharSet", "utf8mb4");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropColumn(
				name: "Type",
				table: "Post");

			migrationBuilder.UpdateData(
				table: "Users",
				keyColumn: "PasswordHash",
				keyValue: null,
				column: "PasswordHash",
				value: "");

			migrationBuilder.AlterColumn<string>(
				name: "PasswordHash",
				table: "Users",
				type: "longtext",
				nullable: false,
				oldClrType: typeof(string),
				oldType: "longtext",
				oldNullable: true)
				.Annotation("MySql:CharSet", "utf8mb4")
				.OldAnnotation("MySql:CharSet", "utf8mb4");

			migrationBuilder.UpdateData(
				table: "Users",
				keyColumn: "Name",
				keyValue: null,
				column: "Name",
				value: "");

			migrationBuilder.AlterColumn<string>(
				name: "Name",
				table: "Users",
				type: "longtext",
				nullable: false,
				oldClrType: typeof(string),
				oldType: "longtext",
				oldNullable: true)
				.Annotation("MySql:CharSet", "utf8mb4")
				.OldAnnotation("MySql:CharSet", "utf8mb4");

			migrationBuilder.UpdateData(
				table: "Users",
				keyColumn: "Email",
				keyValue: null,
				column: "Email",
				value: "");

			migrationBuilder.AlterColumn<string>(
				name: "Email",
				table: "Users",
				type: "longtext",
				nullable: false,
				oldClrType: typeof(string),
				oldType: "longtext",
				oldNullable: true)
				.Annotation("MySql:CharSet", "utf8mb4")
				.OldAnnotation("MySql:CharSet", "utf8mb4");

			migrationBuilder.UpdateData(
				table: "Post",
				keyColumn: "Title",
				keyValue: null,
				column: "Title",
				value: "");

			migrationBuilder.AlterColumn<string>(
				name: "Title",
				table: "Post",
				type: "longtext",
				nullable: false,
				oldClrType: typeof(string),
				oldType: "longtext",
				oldNullable: true)
				.Annotation("MySql:CharSet", "utf8mb4")
				.OldAnnotation("MySql:CharSet", "utf8mb4");

			migrationBuilder.UpdateData(
				table: "Post",
				keyColumn: "Description",
				keyValue: null,
				column: "Description",
				value: "");

			migrationBuilder.AlterColumn<string>(
				name: "Description",
				table: "Post",
				type: "longtext",
				nullable: false,
				oldClrType: typeof(string),
				oldType: "longtext",
				oldNullable: true)
				.Annotation("MySql:CharSet", "utf8mb4")
				.OldAnnotation("MySql:CharSet", "utf8mb4");

			migrationBuilder.UpdateData(
				table: "Commenti",
				keyColumn: "Testo",
				keyValue: null,
				column: "Testo",
				value: "");

			migrationBuilder.AlterColumn<string>(
				name: "Testo",
				table: "Commenti",
				type: "longtext",
				nullable: false,
				oldClrType: typeof(string),
				oldType: "longtext",
				oldNullable: true)
				.Annotation("MySql:CharSet", "utf8mb4")
				.OldAnnotation("MySql:CharSet", "utf8mb4");

			migrationBuilder.UpdateData(
				table: "Commenti",
				keyColumn: "Autore",
				keyValue: null,
				column: "Autore",
				value: "");

			migrationBuilder.AlterColumn<string>(
				name: "Autore",
				table: "Commenti",
				type: "longtext",
				nullable: false,
				oldClrType: typeof(string),
				oldType: "longtext",
				oldNullable: true)
				.Annotation("MySql:CharSet", "utf8mb4")
				.OldAnnotation("MySql:CharSet", "utf8mb4");
		}
	}
}
