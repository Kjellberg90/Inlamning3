using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class added_staff_mentor_selfrelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MentorID",
                table: "Staffs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_MentorID",
                table: "Staffs",
                column: "MentorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Staffs_MentorID",
                table: "Staffs",
                column: "MentorID",
                principalTable: "Staffs",
                principalColumn: "StaffId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Staffs_MentorID",
                table: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_Staffs_MentorID",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "MentorID",
                table: "Staffs");
        }
    }
}
