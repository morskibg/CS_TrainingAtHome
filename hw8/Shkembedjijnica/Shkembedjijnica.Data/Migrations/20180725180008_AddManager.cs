using Microsoft.EntityFrameworkCore.Migrations;

namespace Shkembedjijnica.Data.Migrations
{
    public partial class AddManager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "EmployeesManager",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ManagerId",
                table: "EmployeesManager",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_ManagerId",
                table: "EmployeesManager",
                column: "ManagerId",
                principalTable: "EmployeesManager",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_ManagerId",
                table: "EmployeesManager");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ManagerId",
                table: "EmployeesManager");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "EmployeesManager");
        }
    }
}
