using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InduMovel.Migrations
{
    /// <inheritdoc />
    public partial class incial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Moveis",
                columns: table => new
                {
                    MovelId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Cor = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    ImagemUrl = table.Column<string>(type: "TEXT", nullable: true),
                    ImagemPequena = table.Column<string>(type: "TEXT", nullable: true),
                    Valor = table.Column<double>(type: "REAL", nullable: false),
                    EmProducao = table.Column<string>(type: "TEXT", nullable: true),
                    Ativo = table.Column<string>(type: "TEXT", nullable: true),
                    CategoriaId = table.Column<string>(type: "TEXT", nullable: false),
                    CategoriaId1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moveis", x => x.MovelId);
                    table.ForeignKey(
                        name: "FK_Moveis_Categorias_CategoriaId1",
                        column: x => x.CategoriaId1,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Moveis_CategoriaId1",
                table: "Moveis",
                column: "CategoriaId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Moveis");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
