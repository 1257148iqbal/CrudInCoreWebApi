using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudInCoreWebApi.Migrations
{
    public partial class mg03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trainees",
                columns: new[] { "TraineeID", "Address", "CellPhoneNo", "DateOfBirth", "EmailID", "Gender", "Name" },
                values: new object[] { 1, "Dhaka", "01813148110", new DateTime(1994, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali@gmail.com", "Male", "ALI" });

            migrationBuilder.InsertData(
                table: "Trainees",
                columns: new[] { "TraineeID", "Address", "CellPhoneNo", "DateOfBirth", "EmailID", "Gender", "Name" },
                values: new object[] { 2, "Ctg", "01813148110", new DateTime(1994, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "harami@gmail.com", "Female", "Harami" });

            migrationBuilder.InsertData(
                table: "Trainees",
                columns: new[] { "TraineeID", "Address", "CellPhoneNo", "DateOfBirth", "EmailID", "Gender", "Name" },
                values: new object[] { 3, "Rohingga", "01815501137", new DateTime(1994, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "arefin@gmail.com", "Male", "Arefin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "TraineeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "TraineeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "TraineeID",
                keyValue: 3);
        }
    }
}
