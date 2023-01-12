using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace elearning.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Class",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Class");
        }
    }
}
