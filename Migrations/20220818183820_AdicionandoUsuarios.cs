using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciamentoDeVendas.Migrations
{
    public partial class AdicionandoUsuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Email = table.Column<string>(type: "varchar(767)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    RegiaoResponsavel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Email);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
