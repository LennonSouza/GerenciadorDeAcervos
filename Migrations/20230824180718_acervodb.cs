using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorDeAcervos.Migrations
{
    /// <inheritdoc />
    public partial class acervodb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jacarei_Acervo");

            migrationBuilder.DropColumn(
                name: "AcervoId",
                table: "Setores");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Imagem",
                table: "Usuarios",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldDefaultValue: new byte[0]);

            migrationBuilder.CreateTable(
                name: "Colecao",
                columns: table => new
                {
                    ColecaoId = table.Column<int>(type: "int", nullable: false),
                    ColecoesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Colecoes",
                columns: table => new
                {
                    ColecoesId = table.Column<int>(type: "int", nullable: false),
                    SetorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Colecao");

            migrationBuilder.DropTable(
                name: "Colecoes");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Imagem",
                table: "Usuarios",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldDefaultValue: new byte[0]);

            migrationBuilder.AddColumn<int>(
                name: "AcervoId",
                table: "Setores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Jacarei_Acervo",
                columns: table => new
                {
                    AcervoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });
        }
    }
}
