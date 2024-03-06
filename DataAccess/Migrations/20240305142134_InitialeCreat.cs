using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialeCreat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Applicants_ApplicantId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_ApplicationStates_ApplicationStateId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Bootcamps_BootcampId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Bootcamps_BootcampStates_BootcampStateId",
                table: "Bootcamps");

            migrationBuilder.DropForeignKey(
                name: "FK_Bootcamps_Instructors_InstructorId",
                table: "Bootcamps");

            migrationBuilder.CreateTable(
                name: "Blacklist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlacklistDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicantId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blacklist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blacklist_Applicants_ApplicantId",
                        column: x => x.ApplicantId,
                        principalTable: "Applicants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blacklist_ApplicantId",
                table: "Blacklist",
                column: "ApplicantId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Applicants_ApplicantId",
                table: "Applications",
                column: "ApplicantId",
                principalTable: "Applicants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_ApplicationStates_ApplicationStateId",
                table: "Applications",
                column: "ApplicationStateId",
                principalTable: "ApplicationStates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Bootcamps_BootcampId",
                table: "Applications",
                column: "BootcampId",
                principalTable: "Bootcamps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bootcamps_BootcampStates_BootcampStateId",
                table: "Bootcamps",
                column: "BootcampStateId",
                principalTable: "BootcampStates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bootcamps_Instructors_InstructorId",
                table: "Bootcamps",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Applicants_ApplicantId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_ApplicationStates_ApplicationStateId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Bootcamps_BootcampId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Bootcamps_BootcampStates_BootcampStateId",
                table: "Bootcamps");

            migrationBuilder.DropForeignKey(
                name: "FK_Bootcamps_Instructors_InstructorId",
                table: "Bootcamps");

            migrationBuilder.DropTable(
                name: "Blacklist");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Applicants_ApplicantId",
                table: "Applications",
                column: "ApplicantId",
                principalTable: "Applicants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_ApplicationStates_ApplicationStateId",
                table: "Applications",
                column: "ApplicationStateId",
                principalTable: "ApplicationStates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Bootcamps_BootcampId",
                table: "Applications",
                column: "BootcampId",
                principalTable: "Bootcamps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bootcamps_BootcampStates_BootcampStateId",
                table: "Bootcamps",
                column: "BootcampStateId",
                principalTable: "BootcampStates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bootcamps_Instructors_InstructorId",
                table: "Bootcamps",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
