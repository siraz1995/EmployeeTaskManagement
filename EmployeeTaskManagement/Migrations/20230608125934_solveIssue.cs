using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeTaskManagement.Migrations
{
    public partial class solveIssue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskAssign_EmployeeInfo_EmployeeInfoId",
                table: "TaskAssign");

            migrationBuilder.DropIndex(
                name: "IX_TaskAssign_EmployeeInfoId",
                table: "TaskAssign");

            migrationBuilder.DropColumn(
                name: "EmployeeInfoId",
                table: "TaskAssign");

            migrationBuilder.CreateIndex(
                name: "IX_TaskAssign_EmployeeId",
                table: "TaskAssign",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskAssign_EmployeeInfo_EmployeeId",
                table: "TaskAssign",
                column: "EmployeeId",
                principalTable: "EmployeeInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskAssign_EmployeeInfo_EmployeeId",
                table: "TaskAssign");

            migrationBuilder.DropIndex(
                name: "IX_TaskAssign_EmployeeId",
                table: "TaskAssign");

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
    }
}
