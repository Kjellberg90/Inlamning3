using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class added_product_staff_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_StaffId",
                table: "Products",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Staffs_StaffId",
                table: "Products",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "StaffId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Staffs_StaffId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_StaffId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Products");
        }
    }
}
