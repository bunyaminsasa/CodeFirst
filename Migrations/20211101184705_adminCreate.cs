using Microsoft.EntityFrameworkCore.Migrations;

namespace Level.Migrations
{
    public partial class adminCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSurname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "ID", "NameSurname", "Password", "UserName" },
                values: new object[] { 1, "Bunyamin", "202cb962ac59075b964b07152d234b70", "sasatower" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");
        }
    }
}
