using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeTaskManagement.Migrations
{
    public partial class relationEmployeeInfoToTaskAssign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "TaskAssign",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeInfoId",
                table: "TaskAssign",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaskAssign_EmployeeInfoId",
                table: "TaskAssign",
                column: "EmployeeInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskAssign_EmployeeInfo_EmployeeInfoId",
                table: "TaskAssign",
                column: "EmployeeInfoId",
                principalTable: "EmployeeInfo",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskAssign_EmployeeInfo_EmployeeInfoId",
                table: "TaskAssign");

            migrationBuilder.DropIndex(
                name: "IX_TaskAssign_EmployeeInfoId",
                table: "TaskAssign");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "TaskAssign");

            migrationBuilder.DropColumn(
                name: "EmployeeInfoId",
                table: "TaskAssign");
        }
    }
}
