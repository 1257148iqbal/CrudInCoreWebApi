using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudInCoreWebApi.Migrations
{
    public partial class mg02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CellPhoneNo",
                table: "Trainees",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CellPhoneNo",
                table: "Trainees");
        }
    }
}
