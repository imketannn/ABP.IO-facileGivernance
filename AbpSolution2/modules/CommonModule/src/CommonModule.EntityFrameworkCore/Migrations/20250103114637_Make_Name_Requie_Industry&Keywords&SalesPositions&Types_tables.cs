using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommonModule.Migrations
{
    /// <inheritdoc />
    public partial class Make_Name_Requie_IndustryKeywordsSalesPositionsTypes_tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CommonModuleTypes",
                table: "CommonModuleTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommonModuleSalesPositions",
                table: "CommonModuleSalesPositions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommonModuleKeywords",
                table: "CommonModuleKeywords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommonModuleIndustry",
                table: "CommonModuleIndustry");

            migrationBuilder.RenameTable(
                name: "CommonModuleTypes",
                newName: "Types");

            migrationBuilder.RenameTable(
                name: "CommonModuleSalesPositions",
                newName: "SalesPositions");

            migrationBuilder.RenameTable(
                name: "CommonModuleKeywords",
                newName: "Keywords");

            migrationBuilder.RenameTable(
                name: "CommonModuleIndustry",
                newName: "Industry");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Industry",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Types",
                table: "Types",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesPositions",
                table: "SalesPositions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Keywords",
                table: "Keywords",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Industry",
                table: "Industry",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Types",
                table: "Types");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesPositions",
                table: "SalesPositions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Keywords",
                table: "Keywords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Industry",
                table: "Industry");

            migrationBuilder.RenameTable(
                name: "Types",
                newName: "CommonModuleTypes");

            migrationBuilder.RenameTable(
                name: "SalesPositions",
                newName: "CommonModuleSalesPositions");

            migrationBuilder.RenameTable(
                name: "Keywords",
                newName: "CommonModuleKeywords");

            migrationBuilder.RenameTable(
                name: "Industry",
                newName: "CommonModuleIndustry");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CommonModuleIndustry",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommonModuleTypes",
                table: "CommonModuleTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommonModuleSalesPositions",
                table: "CommonModuleSalesPositions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommonModuleKeywords",
                table: "CommonModuleKeywords",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommonModuleIndustry",
                table: "CommonModuleIndustry",
                column: "Id");
        }
    }
}
