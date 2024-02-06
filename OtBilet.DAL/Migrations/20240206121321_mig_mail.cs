using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OtBilet.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig_mail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mail",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mail",
                table: "Passengers");
        }
    }
}
