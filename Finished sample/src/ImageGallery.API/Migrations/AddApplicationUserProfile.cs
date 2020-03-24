using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImageGallery.API.Migrations
{
    public partial class AddApplicationUserProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUserProfiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Subject = table.Column<string>(maxLength: 50, nullable: false),
                    SubscriptionLevel = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserProfiles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ApplicationUserProfiles",
                columns: new[] { "Id", "Subject", "SubscriptionLevel" },
                values: new object[] { new Guid("7f8ce18c-d156-4c85-9575-56bf59938b0c"), "d860efca-22d9-47fd-8249-791ba61b07c7", "FreeUser" });

            migrationBuilder.InsertData(
                table: "ApplicationUserProfiles",
                columns: new[] { "Id", "Subject", "SubscriptionLevel" },
                values: new object[] { new Guid("38ff72e7-834a-4f5d-a0d1-acfaffad05c2"), "b7539694-97e7-4dfe-84da-b4256e1ff5c7", "PayingUser" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserProfiles");
        }
    }
}
