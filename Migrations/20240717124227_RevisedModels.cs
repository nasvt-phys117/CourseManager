using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseManager.Migrations
{
    /// <inheritdoc />
    public partial class RevisedModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Teacher");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Teacher",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
