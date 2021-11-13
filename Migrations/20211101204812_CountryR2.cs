using Microsoft.EntityFrameworkCore.Migrations;

namespace Level.Migrations
{
    public partial class CountryR2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tour_Country_CountryID",
                table: "Tour");

            migrationBuilder.AddForeignKey(
                name: "FK_Tour_Country_CountryID",
                table: "Tour",
                column: "CountryID",
                principalTable: "Country",
                principalColumn: "ID",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tour_Country_CountryID",
                table: "Tour");

            migrationBuilder.AddForeignKey(
                name: "FK_Tour_Country_CountryID",
                table: "Tour",
                column: "CountryID",
                principalTable: "Country",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
