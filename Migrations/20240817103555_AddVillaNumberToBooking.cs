using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DummyWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddVillaNumberToBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VillaNumber",       // Current name of the column
                table: "Bookings",         // Table name
                newName: "Villa_Number");  // New name of the column
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Villa_Number",      // Name of the column after migration
                table: "Bookings",         // Table name
                newName: "VillaNumber");   // Revert to the original name
        }
    }

}
