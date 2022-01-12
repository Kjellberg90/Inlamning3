using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class added_department_staff_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_StaffId",
                table: "Departments",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Staffs_StaffId",
                table: "Departments",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "StaffId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Staffs_StaffId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_StaffId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Departments");
        }
    }
}
