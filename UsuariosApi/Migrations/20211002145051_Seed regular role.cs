using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class Seedregularrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "79f2cb45-1483-4f50-93b3-6f9db0983680");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99998, "29734913-7393-4b22-bbcc-5be521864167", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9996540d-7d98-43ad-ac9c-4a4694fd57f6", "AQAAAAEAACcQAAAAEPMjVRjXWYbd900sspvfK0tFo85tz0zfP5jUtAqQVVJptWKtpoCbCwG2bkv5/PeY+g==", "9919ee4a-9cbc-4da2-87e6-de7221e376f9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "17798c16-0645-4a57-b8a5-afc076af1ca4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "138c1b95-b7de-427d-b569-1cff3f2206e8", "AQAAAAEAACcQAAAAELWj5cMAtALsQ3ZpjoeMRkv7ec5Yi73VHbOJZr2Z6xJL2tQmbb+HoWbZRMyuPaA2ZA==", "7df39e7d-f17c-49c1-ac1d-d6cce75fcf65" });
        }
    }
}
