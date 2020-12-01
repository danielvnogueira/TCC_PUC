using Microsoft.EntityFrameworkCore.Migrations;

namespace Consultorio.WebAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agendas",
                columns: table => new
                {
                    AgendaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomePaciente = table.Column<string>(nullable: true),
                    Local = table.Column<string>(nullable: true),
                    Data = table.Column<string>(nullable: true),
                    Sintomas = table.Column<string>(nullable: true),
                    DiasAfastado = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendas", x => x.AgendaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendas");
        }
    }
}
