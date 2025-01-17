using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Master.Rotas.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rotas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Origem = table.Column<string>(type: "varchar(100)", nullable: false),
                    Destino = table.Column<string>(type: "varchar(100)", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rotas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rotas");
        }
    }
}
