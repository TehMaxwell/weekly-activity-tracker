using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeeklyActivityTracker.WeeklyTargetAPI.InitDatabase.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeeklyTargets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TargetName = table.Column<string>(type: "text", nullable: false),
                    TargetDecription = table.Column<string>(type: "text", nullable: false),
                    TargetCreatedTimestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TargetCompleteByTimestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TargetCompletedTimestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeeklyTargets", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeeklyTargets");
        }
    }
}
