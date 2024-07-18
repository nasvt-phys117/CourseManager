using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseManager.Migrations
{
    /// <inheritdoc />
    public partial class TestingTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Course_CourseId",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_CourseId",
                table: "Teacher");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Teacher",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Course",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Course_TeacherId",
                table: "Course",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Teacher_TeacherId",
                table: "Course",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Teacher_TeacherId",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_TeacherId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Course");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Teacher",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_CourseId",
                table: "Teacher",
                column: "CourseId",
                unique: true,
                filter: "[CourseId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Course_CourseId",
                table: "Teacher",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id");
        }
    }
}
