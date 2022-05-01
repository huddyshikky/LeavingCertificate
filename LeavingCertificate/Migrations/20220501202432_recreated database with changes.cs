using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeavingCertificate.Migrations
{
    public partial class recreateddatabasewithchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SchoolDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    schname = table.Column<string>(nullable: true),
                    schaddr = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    schmotto = table.Column<string>(nullable: true),
                    schemail = table.Column<string>(nullable: true),
                    schweb = table.Column<string>(nullable: true),
                    schtel = table.Column<string>(nullable: true),
                    postalcode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Streams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StreamName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Streams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AdmNo = table.Column<int>(nullable: false),
                    StudName = table.Column<string>(nullable: true),
                    ClassFirstEnrolled = table.Column<string>(nullable: true),
                    Category = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    DateOfAdmission = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    StreamId = table.Column<int>(nullable: false),
                    LeavingCertDetailsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Streams_StreamId",
                        column: x => x.StreamId,
                        principalTable: "Streams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeavingCertDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Comment = table.Column<string>(nullable: true),
                    Leaving_Date = table.Column<DateTime>(nullable: false),
                    ClassOfLeaving = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeavingCertDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeavingCertDetails_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LeavingCertDetails_StudentId",
                table: "LeavingCertDetails",
                column: "StudentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_StreamId",
                table: "Students",
                column: "StreamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeavingCertDetails");

            migrationBuilder.DropTable(
                name: "SchoolDetails");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Streams");
        }
    }
}
