using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ChangeSchemaToResume : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "resume");

            migrationBuilder.RenameTable(
                name: "Jobs",
                newName: "Jobs",
                newSchema: "resume");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "Companies",
                newSchema: "resume");

            migrationBuilder.RenameTable(
                name: "Candidates",
                newName: "Candidates",
                newSchema: "resume");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Jobs",
                schema: "resume",
                newName: "Jobs");

            migrationBuilder.RenameTable(
                name: "Companies",
                schema: "resume",
                newName: "Companies");

            migrationBuilder.RenameTable(
                name: "Candidates",
                schema: "resume",
                newName: "Candidates");
        }
    }
}
