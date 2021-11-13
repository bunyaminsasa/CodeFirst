using Microsoft.EntityFrameworkCore.Migrations;

namespace Level.Migrations
{
    public partial class CountryR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryID",
                table: "Tour",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "Country",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tour_CountryID",
                table: "Tour",
                column: "CountryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tour_Country_CountryID",
                table: "Tour",
                column: "CountryID",
                principalTable: "Country",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tour_Country_CountryID",
                table: "Tour");

            migrationBuilder.DropIndex(
                name: "IX_Tour_CountryID",
                table: "Tour");

            migrationBuilder.DropColumn(
                name: "CountryID",
                table: "Tour");

            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Country");
        }
    }
}
