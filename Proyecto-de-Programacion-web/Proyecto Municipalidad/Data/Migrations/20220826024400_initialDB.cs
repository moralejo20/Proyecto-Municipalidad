using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_Municipalidad.Data.Migrations
{
    public partial class initialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipo",
                columns: table => new
                {
                    idNoticia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    noticaTitulo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cuerpoNoticia = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    autorNoticia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipo", x => x.idNoticia);
                });

            migrationBuilder.CreateTable(
                name: "Equipo2",
                columns: table => new
                {
                    idEvento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    eventoTitulo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cuerpoevento = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    autorEvento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipo2", x => x.idEvento);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipo");

            migrationBuilder.DropTable(
                name: "Equipo2");
        }
    }
}
