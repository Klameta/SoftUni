using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForumApp.Migrations
{
    public partial class seeding20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Posts",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { new Guid("24d9cfb9-6263-48ab-815b-a8099e4d1984"), "Hello world! I am using this website for the first time and im hoping that i can make some friendse here! :D", "This is my first post! Wooo!" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { new Guid("34bfb7db-d393-46af-bde2-acd9efd525d6"), "Thank you guys! What you've all said has really helped me overcome my problem and im so grateful to be on this site with such amazing people!", "Thanks!" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { new Guid("56e6c087-bf00-4dcc-bddd-ad097cc94fbe"), "Hello friends! I am asking for some help on a problme I have been having for the past couple of days because i just can't seem to find a suitable solution...", "Hello there!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("24d9cfb9-6263-48ab-815b-a8099e4d1984"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("34bfb7db-d393-46af-bde2-acd9efd525d6"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("56e6c087-bf00-4dcc-bddd-ad097cc94fbe"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Posts",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);
        }
    }
}
