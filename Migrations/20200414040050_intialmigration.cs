using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhotoAwards.Migrations
{
    public partial class intialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contest",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Prize = table.Column<int>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    EndsOn = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contest", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    displayName = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    gender = table.Column<string>(nullable: true),
                    profileImage = table.Column<string>(nullable: true),
                    credits = table.Column<int>(nullable: false),
                    loggedVia = table.Column<string>(nullable: true),
                    isprofileCompleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DBEntry",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: false),
                    UserID = table.Column<Guid>(nullable: false),
                    ContestsID = table.Column<Guid>(nullable: false),
                    isBoosted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBEntry", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DBEntry_Contest_ContestsID",
                        column: x => x.ContestsID,
                        principalTable: "Contest",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Voting",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UserID = table.Column<Guid>(nullable: false),
                    ContestID = table.Column<Guid>(nullable: false),
                    EntryID = table.Column<Guid>(nullable: false),
                    Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voting", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Voting_Contest_ContestID",
                        column: x => x.ContestID,
                        principalTable: "Contest",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DBEntry_ContestsID",
                table: "DBEntry",
                column: "ContestsID");

            migrationBuilder.CreateIndex(
                name: "IX_Voting_ContestID",
                table: "Voting",
                column: "ContestID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DBEntry");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Voting");

            migrationBuilder.DropTable(
                name: "Contest");
        }
    }
}
