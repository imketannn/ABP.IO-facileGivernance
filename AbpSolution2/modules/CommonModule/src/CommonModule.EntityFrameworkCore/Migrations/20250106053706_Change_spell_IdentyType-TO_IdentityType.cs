using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommonModule.Migrations
{
    /// <inheritdoc />
    public partial class Change_spell_IdentyTypeTO_IdentityType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdentyType",
                table: "Types",
                newName: "IdentityType");

            migrationBuilder.RenameColumn(
                name: "IdentyType",
                table: "Keywords",
                newName: "IdentityType");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdentityType",
                table: "Types",
                newName: "IdentyType");

            migrationBuilder.RenameColumn(
                name: "IdentityType",
                table: "Keywords",
                newName: "IdentyType");
        }
    }
}
