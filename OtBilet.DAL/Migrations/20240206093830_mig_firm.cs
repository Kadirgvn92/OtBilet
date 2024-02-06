using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OtBilet.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig_firm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirmImageUrl",
                table: "Buses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirmName",
                table: "Buses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirmImageUrl",
                table: "Buses");

            migrationBuilder.DropColumn(
                name: "FirmName",
                table: "Buses");
        }
    }
}
