using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagement.API.Migrations
{
    /// <inheritdoc />
    public partial class Aravind : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentFeesDetails_FeeTerms_FeeTermsId",
                table: "StudentFeesDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_DriverDetails_DriverDetailsId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "FeeTerms");

            migrationBuilder.DropIndex(
                name: "IX_Students_DriverDetailsId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_StudentFeesDetails_FeeTermsId",
                table: "StudentFeesDetails");

            migrationBuilder.DropColumn(
                name: "DriverDetailsId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FeeTermsId",
                table: "StudentFeesDetails");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DriverDetailsId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FeeTermsId",
                table: "StudentFeesDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FeeTerms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmountToBe = table.Column<long>(type: "bigint", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeeTerms", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_DriverDetailsId",
                table: "Students",
                column: "DriverDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentFeesDetails_FeeTermsId",
                table: "StudentFeesDetails",
                column: "FeeTermsId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentFeesDetails_FeeTerms_FeeTermsId",
                table: "StudentFeesDetails",
                column: "FeeTermsId",
                principalTable: "FeeTerms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_DriverDetails_DriverDetailsId",
                table: "Students",
                column: "DriverDetailsId",
                principalTable: "DriverDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
