using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Marvin.IDP.Migrations
{
    public partial class AddUserLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("183a8900-3559-46b2-af11-9ff2ab1d3b85"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("30baa3d6-ada0-4562-a155-287952dfcd0a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("69d18928-9fa5-4354-bb73-5f87e96ca820"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("78446cba-775d-4d68-9681-98b48fa19eeb"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("90e32a5e-e7c5-4b9a-b8c6-f87fcf369d9c"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("9e40672c-298a-4607-80a7-a306e86c9c51"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("b8fcdcc7-a3d6-48a1-86ee-9f8302660184"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("d15fac5e-e64b-466a-8b6b-20ff873dc8ae"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("eba6076c-b11e-48da-ae21-4882807ebb6c"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("f3582ff4-096e-4f39-bbb9-66652773e5b9"));

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Provider = table.Column<string>(maxLength: 200, nullable: false),
                    ProviderIdentityKey = table.Column<string>(maxLength: 200, nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
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

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserLogins");

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

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("eba6076c-b11e-48da-ae21-4882807ebb6c"), "7a14a085-4849-4e0d-addd-ff1884517f4e", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Frank" },
                    { new Guid("d15fac5e-e64b-466a-8b6b-20ff873dc8ae"), "a857e6e3-4963-4f1f-8137-2074a837c7e3", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Underwood" },
                    { new Guid("b8fcdcc7-a3d6-48a1-86ee-9f8302660184"), "c5375cda-55e3-4288-9e0d-72b6b49792c0", "email", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "frank@someprovider.com" },
                    { new Guid("69d18928-9fa5-4354-bb73-5f87e96ca820"), "4e69cbd8-5d3b-43ed-b613-4c11e6421d09", "address", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Main Road 1" },
                    { new Guid("78446cba-775d-4d68-9681-98b48fa19eeb"), "c30bb322-84e3-41b8-9d58-e9bcf0f120bb", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("30baa3d6-ada0-4562-a155-287952dfcd0a"), "ddca12de-3a2c-4af1-a6c4-a0038b913232", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Claire" },
                    { new Guid("9e40672c-298a-4607-80a7-a306e86c9c51"), "9b23709a-407e-4824-9b37-cef2fe5ebec5", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Underwood" },
                    { new Guid("90e32a5e-e7c5-4b9a-b8c6-f87fcf369d9c"), "edccb650-394e-4fab-bf56-1f85dadbedde", "email", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "claire@someprovider.com" },
                    { new Guid("f3582ff4-096e-4f39-bbb9-66652773e5b9"), "418dd944-e7ac-4988-ad4f-1a21566de41b", "address", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Big Street 2" },
                    { new Guid("183a8900-3559-46b2-af11-9ff2ab1d3b85"), "64d6f0e0-6866-4ddd-9d02-b91a4dbdd6b6", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "0c99ade8-3df9-460a-9a8f-6844d28414d9");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "4643f126-81bc-45fd-b87b-d1f0daa6cedf");
        }
    }
}
