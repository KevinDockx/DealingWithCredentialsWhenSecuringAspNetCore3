using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Marvin.IDP.Migrations
{
    public partial class AddUserSecret : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("0612f294-26db-4901-810c-adcc8eee9b59"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("157de93d-471d-4453-92a8-2baba25a503f"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("30ef0d5b-3971-4e55-9cc8-fd7f96d1dee5"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("4b8683bc-67a8-4381-935b-d1285e737c7b"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("577d96bf-2c45-4d36-930b-42e321421d96"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("5be0b45a-6a3a-4e5f-b73c-c4a2fabac663"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("7045b214-af0f-4d26-90d9-6092c63aee45"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("884ef2b0-2046-4e09-b50f-3aac739c3cb7"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("9681c0b1-32ca-4312-a67b-4bf2acb3f59e"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("f00e4362-bfe9-4865-a8d2-4aee2a0b4e85"));

            migrationBuilder.CreateTable(
                name: "UserSecrets",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Secret = table.Column<string>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSecrets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSecrets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("06d107e6-17e2-41b0-9e32-0e7016ad5b3c"), "f0f985a0-8d83-4b1c-90dd-fea75608d7e6", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Frank" },
                    { new Guid("3e37f48a-45d2-498f-9bb7-9020972a101c"), "2d2c2848-1ce8-482d-98f6-9896d16c79dc", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Underwood" },
                    { new Guid("42431d3b-c7d2-4442-a20f-b3dd1e64f29d"), "dfca0b84-b22e-4ad9-8fd5-a373010b42ad", "email", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "frank@someprovider.com" },
                    { new Guid("88849b77-f20d-4cf9-bf65-0b3acd005839"), "1fe0710b-0784-4f49-9919-56c1bf546285", "address", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Main Road 1" },
                    { new Guid("7e241450-eeb9-487f-9699-3fa30b767e19"), "774e82bb-810a-4d65-97fd-be858c83144e", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("a0fdac1f-dfb9-4468-a8f5-5fd2d575828d"), "45b05c80-3689-4d35-aa8a-017683b4efd6", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Claire" },
                    { new Guid("2f8bc440-e8bb-401a-85fa-db1b0489704f"), "76de2b7e-2fb8-4658-b513-b08b6cfd5aff", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Underwood" },
                    { new Guid("28ade92c-8b15-4750-93e5-22601b6396f4"), "fd6b3238-1f4a-4718-902d-1870a66b77a9", "email", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "claire@someprovider.com" },
                    { new Guid("1ae537e3-180a-4645-acda-bb6ab98c9be1"), "e556226c-fe22-4f0c-940b-38acd49ae141", "address", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Big Street 2" },
                    { new Guid("2de2aeda-4ed3-4eeb-b041-4d12b008b2c3"), "b37c646d-2642-4caa-bf37-07156f40ad72", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "69407ae3-cc5c-4e83-9374-c8cf6b93aba5");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "1230c979-5d1a-46bc-a57c-1c4ad32fae34");

            migrationBuilder.CreateIndex(
                name: "IX_UserSecrets_UserId",
                table: "UserSecrets",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSecrets");

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("06d107e6-17e2-41b0-9e32-0e7016ad5b3c"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("1ae537e3-180a-4645-acda-bb6ab98c9be1"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("28ade92c-8b15-4750-93e5-22601b6396f4"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("2de2aeda-4ed3-4eeb-b041-4d12b008b2c3"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("2f8bc440-e8bb-401a-85fa-db1b0489704f"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("3e37f48a-45d2-498f-9bb7-9020972a101c"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("42431d3b-c7d2-4442-a20f-b3dd1e64f29d"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("7e241450-eeb9-487f-9699-3fa30b767e19"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("88849b77-f20d-4cf9-bf65-0b3acd005839"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("a0fdac1f-dfb9-4468-a8f5-5fd2d575828d"));

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("157de93d-471d-4453-92a8-2baba25a503f"), "dfc04be2-4a0e-4d8f-9f76-9b8a80cae288", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Frank" },
                    { new Guid("577d96bf-2c45-4d36-930b-42e321421d96"), "4b0d4251-b834-40b6-aaff-e68e9c2e00d0", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Underwood" },
                    { new Guid("30ef0d5b-3971-4e55-9cc8-fd7f96d1dee5"), "d5c74387-b0ee-45da-9754-6a43328cff78", "email", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "frank@someprovider.com" },
                    { new Guid("4b8683bc-67a8-4381-935b-d1285e737c7b"), "998f6344-15ee-4f60-b2a2-2a394d5dd1f2", "address", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Main Road 1" },
                    { new Guid("9681c0b1-32ca-4312-a67b-4bf2acb3f59e"), "e856f08e-1593-4dbb-8e9b-14a5b5974a82", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("7045b214-af0f-4d26-90d9-6092c63aee45"), "28994527-fd3b-42ca-9591-16e832f2b7dd", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Claire" },
                    { new Guid("5be0b45a-6a3a-4e5f-b73c-c4a2fabac663"), "110c70e4-e273-4b63-83e6-bd9b188f1a59", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Underwood" },
                    { new Guid("f00e4362-bfe9-4865-a8d2-4aee2a0b4e85"), "45ae6faa-b0a9-4bec-8f2d-c089ffcdfc20", "email", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "claire@someprovider.com" },
                    { new Guid("0612f294-26db-4901-810c-adcc8eee9b59"), "f3333a93-e5d6-417f-ad4e-49d04c980706", "address", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Big Street 2" },
                    { new Guid("884ef2b0-2046-4e09-b50f-3aac739c3cb7"), "aa0e4008-ea21-43ff-9f91-94405784a910", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "2ef36ac6-94ec-4fc1-bc93-cde96915c1f0");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "08509b4d-df79-4cf3-8d69-a820af26cc10");
        }
    }
}
