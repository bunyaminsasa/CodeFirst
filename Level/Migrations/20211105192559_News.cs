using Microsoft.EntityFrameworkCore.Migrations;

namespace Level.Migrations
{
    public partial class News : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tour_Country_CountryID",
                table: "Tour");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true),
                    Picture = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.ID);
                    table.ForeignKey(
                        name: "FK_News_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_News_CategoryID",
                table: "News",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tour_Country_CountryID",
                table: "Tour",
                column: "CountryID",
                principalTable: "Country",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tour_Country_CountryID",
                table: "Tour");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.AddForeignKey(
                name: "FK_Tour_Country_CountryID",
                table: "Tour",
                column: "CountryID",
                principalTable: "Country",
                principalColumn: "ID",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
