using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Migrations
{
    public partial class AddedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Element", "Email", "Name" },
                values: new object[] { 1, 4, "rod@slav.god", "Rod" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Element", "Email", "Name" },
                values: new object[] { 2, 3, "perun@slav.god", "Perun" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Element", "Email", "Name" },
                values: new object[] { 3, 1, "Svarog", "Svarog" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
