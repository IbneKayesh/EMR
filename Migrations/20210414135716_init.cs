using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EMR.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DOCTORS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MOBILE_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOCTOR_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATE_OF_BIRTH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CERTIFICATION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOCTOR_SEX = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOCTORS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PATIENTS",
                columns: table => new
                {
                    MOBILE_NUMBER = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PATIENTS_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATE_OF_BIRTH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PATIENTS_SEX = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PATIENTS", x => x.MOBILE_NUMBER);
                });

            migrationBuilder.CreateTable(
                name: "PRESCRIPTIONS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DOCTORS_ID = table.Column<int>(type: "int", nullable: false),
                    PRESCRIPTIONS_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRESCRIBE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PATIENTS_MOBILE_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PATIENTS_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AGE_YEAR = table.Column<int>(type: "int", nullable: false),
                    AGE_MONTH = table.Column<int>(type: "int", nullable: false),
                    AGE_DAYS = table.Column<int>(type: "int", nullable: false),
                    PATIENTS_SEX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BLOOD_GROUP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TEMPERATURE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WEIGHT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROBLEMS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VISIT_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VISIT_FEES = table.Column<decimal>(type: "decimal(3,2)", precision: 3, scale: 2, nullable: false),
                    REF_PRESCRIPTIONS_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REQUIRED_ADMISSION = table.Column<bool>(type: "bit", nullable: false),
                    INSTRUCTIONS = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRESCRIPTIONS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PRESCRIPTIONS_DRUGS",
                columns: table => new
                {
                    PRESCRIPTIONS_ID = table.Column<long>(type: "bigint", nullable: false),
                    LINE_NO = table.Column<int>(type: "int", nullable: false),
                    DRUGS_ID = table.Column<int>(type: "int", nullable: false),
                    DRUGS_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FREQUENCY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DURATION = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRESCRIPTIONS_DRUGS", x => new { x.PRESCRIPTIONS_ID, x.LINE_NO });
                    table.ForeignKey(
                        name: "FK_PRESCRIPTIONS_DRUGS_PRESCRIPTIONS_PRESCRIPTIONS_ID",
                        column: x => x.PRESCRIPTIONS_ID,
                        principalTable: "PRESCRIPTIONS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PRESCRIPTIONS_INVES",
                columns: table => new
                {
                    PRESCRIPTIONS_ID = table.Column<long>(type: "bigint", nullable: false),
                    LINE_NO = table.Column<int>(type: "int", nullable: false),
                    INVESTIGATIONS_ID = table.Column<int>(type: "int", nullable: false),
                    INVESTIGATIONS_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INSTRUCTIONS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REF_DIAGNOSTICS = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRESCRIPTIONS_INVES", x => new { x.PRESCRIPTIONS_ID, x.LINE_NO });
                    table.ForeignKey(
                        name: "FK_PRESCRIPTIONS_INVES_PRESCRIPTIONS_PRESCRIPTIONS_ID",
                        column: x => x.PRESCRIPTIONS_ID,
                        principalTable: "PRESCRIPTIONS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DOCTORS");

            migrationBuilder.DropTable(
                name: "PATIENTS");

            migrationBuilder.DropTable(
                name: "PRESCRIPTIONS_DRUGS");

            migrationBuilder.DropTable(
                name: "PRESCRIPTIONS_INVES");

            migrationBuilder.DropTable(
                name: "PRESCRIPTIONS");
        }
    }
}
