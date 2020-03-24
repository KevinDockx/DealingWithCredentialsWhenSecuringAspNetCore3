using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Marvin.IDP.Migrations
{
    public partial class AddEmailAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("0786ad36-7a60-484a-9dd4-f17342dc02e1"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("26e31fe1-3bc8-488e-aa0f-9067782f71ab"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("2f7fc90c-9b9b-45d5-8bdf-d4e29e2b454a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("53be613a-b495-4ef3-8549-10e879d2d06a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("991644f5-93e8-4185-bf56-efa2fdda7b85"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("9af868e4-b0b5-4f59-bf6c-d5e4b0bd357f"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("b7fb94bb-ab8a-41c4-aa02-595c1215938b"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("c398875b-49e1-41d3-88ea-872199c8f435"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("daf7f0f4-8811-4451-b9c8-ed86d5062f06"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("f2890495-8e14-4967-a5a3-7a38a2555dcf"));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecurityCode",
                table: "Users",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SecurityCodeExpirationDate",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCodeExpirationDate",
                table: "Users");

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("9af868e4-b0b5-4f59-bf6c-d5e4b0bd357f"), "af1e924d-7bee-403c-bfce-e9d2f27a7f71", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Frank" },
                    { new Guid("2f7fc90c-9b9b-45d5-8bdf-d4e29e2b454a"), "7e87e4f3-abc6-491f-82df-c5feac1b9d58", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Underwood" },
                    { new Guid("0786ad36-7a60-484a-9dd4-f17342dc02e1"), "57db31b0-8ecf-46e4-b996-3cbf8f1bce83", "address", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Main Road 1" },
                    { new Guid("daf7f0f4-8811-4451-b9c8-ed86d5062f06"), "ff2f752d-bec1-400c-a68d-1055562134bb", "subscriptionlevel", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("26e31fe1-3bc8-488e-aa0f-9067782f71ab"), "dcfd0e45-d27a-4717-a271-b0c14db9e7b4", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("f2890495-8e14-4967-a5a3-7a38a2555dcf"), "5a034467-be14-49d0-9f6a-671333539b41", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Claire" },
                    { new Guid("b7fb94bb-ab8a-41c4-aa02-595c1215938b"), "73f02060-d43e-42f9-8195-63db6f334593", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Underwood" },
                    { new Guid("c398875b-49e1-41d3-88ea-872199c8f435"), "8f833904-26fe-4ffa-a96e-8347a69d4dc6", "address", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Big Street 2" },
                    { new Guid("991644f5-93e8-4185-bf56-efa2fdda7b85"), "adc6de2b-5d6d-43f3-b53b-4d650a93cba9", "subscriptionlevel", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("53be613a-b495-4ef3-8549-10e879d2d06a"), "9ea3d865-bda8-4342-8ed4-135dcf8f9cae", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "910fb737-cee5-45f0-903e-c6d877712765");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "6b796a9d-2fbf-4185-8508-3f186df39f61");
        }
    }
}
