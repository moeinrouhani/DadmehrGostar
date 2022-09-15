using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace File.EfCore.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BoardTypes",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoardTypes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArchiveNo = table.Column<long>(type: "bigint", nullable: false),
                    ClientVisitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProceederReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reqester = table.Column<long>(type: "bigint", nullable: false),
                    Summoned = table.Column<long>(type: "bigint", nullable: false),
                    Client = table.Column<bool>(type: "bit", nullable: false),
                    FileClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasMandate = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Boards",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisputeResolutionPetitionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoardChairman = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpertReport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    File_Id = table.Column<long>(type: "bigint", nullable: false),
                    BoardType_Id = table.Column<long>(type: "bigint", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boards", x => x.id);
                    table.ForeignKey(
                        name: "FK_Boards_BoardTypes_BoardType_Id",
                        column: x => x.BoardType_Id,
                        principalTable: "BoardTypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Boards_Files_File_Id",
                        column: x => x.File_Id,
                        principalTable: "Files",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Petitions",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetitionIssuanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NotificationPetitionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPenalty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalPenaltyTitles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Board_Id = table.Column<long>(type: "bigint", nullable: false),
                    File_Id = table.Column<long>(type: "bigint", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Petitions", x => x.id);
                    table.ForeignKey(
                        name: "FK_Petitions_Boards_Board_Id",
                        column: x => x.Board_Id,
                        principalTable: "Boards",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Petitions_Files_File_Id",
                        column: x => x.File_Id,
                        principalTable: "Files",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProceedingSessions",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Board_Id = table.Column<long>(type: "bigint", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProceedingSessions", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProceedingSessions_Boards_Board_Id",
                        column: x => x.Board_Id,
                        principalTable: "Boards",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PenaltyTitles",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Petition_Id = table.Column<long>(type: "bigint", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PenaltyTitles", x => x.id);
                    table.ForeignKey(
                        name: "FK_PenaltyTitles_Petitions_Petition_Id",
                        column: x => x.Petition_Id,
                        principalTable: "Petitions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkHistories",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkingHoursPerDay = table.Column<int>(type: "int", nullable: false),
                    WorkingHoursPerWeek = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Petition_Id = table.Column<long>(type: "bigint", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkHistories", x => x.id);
                    table.ForeignKey(
                        name: "FK_WorkHistories_Petitions_Petition_Id",
                        column: x => x.Petition_Id,
                        principalTable: "Petitions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Boards_BoardType_Id",
                table: "Boards",
                column: "BoardType_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Boards_File_Id",
                table: "Boards",
                column: "File_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PenaltyTitles_Petition_Id",
                table: "PenaltyTitles",
                column: "Petition_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Petitions_Board_Id",
                table: "Petitions",
                column: "Board_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Petitions_File_Id",
                table: "Petitions",
                column: "File_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProceedingSessions_Board_Id",
                table: "ProceedingSessions",
                column: "Board_Id");

            migrationBuilder.CreateIndex(
                name: "IX_WorkHistories_Petition_Id",
                table: "WorkHistories",
                column: "Petition_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PenaltyTitles");

            migrationBuilder.DropTable(
                name: "ProceedingSessions");

            migrationBuilder.DropTable(
                name: "WorkHistories");

            migrationBuilder.DropTable(
                name: "Petitions");

            migrationBuilder.DropTable(
                name: "Boards");

            migrationBuilder.DropTable(
                name: "BoardTypes");

            migrationBuilder.DropTable(
                name: "Files");
        }
    }
}
