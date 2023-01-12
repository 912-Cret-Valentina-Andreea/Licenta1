using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace elearning.Migrations
{
    /// <inheritdoc />
    public partial class AddTeacherIdToClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NoStudents",
                table: "Class",
                newName: "TeacherId");

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId",
                table: "Students",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Class_ClassId",
                table: "Students",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Class_ClassId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ClassId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Class",
                newName: "NoStudents");
        }
    }
}
