using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_codeFirst.Migrations
{
    public partial class Gen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Project",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Request = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientId", "DateOfBirth", "FirstName", "LastName", "Request" },
                values: new object[,]
                {
                    { 1, new DateTime(1988, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Olena", "Ivanova", "lalal" },
                    { 2, new DateTime(1986, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gleb", "Ivanov", "olololol" },
                    { 3, new DateTime(1986, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vlad", "Glech", "allalala" },
                    { 4, new DateTime(1996, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dima", "Chern", "lslslsls" },
                    { 5, new DateTime(1988, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Max", "Kosten", "lwlwwllw" }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "Budget", "ClientId", "Name", "Starteddate" },
                values: new object[,]
                {
                    { 1, 500m, 1, "alal", new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 300m, 1, "ooops", new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 560987m, 2, "nononono", new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 234m, 3, "ooopSSs", new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 300m, 4, "oOOoops", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 2345m, 5, "FGGFG", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Project_ClientId",
                table: "Project",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Client_ClientId",
                table: "Project",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Client_ClientId",
                table: "Project");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Project_ClientId",
                table: "Project");

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Project");
        }
    }
}
