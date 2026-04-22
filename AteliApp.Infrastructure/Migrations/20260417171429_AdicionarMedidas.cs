using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AteliApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarMedidas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medidas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    IdCliente = table.Column<Guid>(type: "TEXT", nullable: false),
                    Altura = table.Column<decimal>(type: "REAL", nullable: true),
                    Busto = table.Column<decimal>(type: "REAL", nullable: true),
                    Cintura = table.Column<decimal>(type: "REAL", nullable: true),
                    Quadril = table.Column<decimal>(type: "REAL", nullable: true),
                    Ombro = table.Column<decimal>(type: "REAL", nullable: true),
                    Outros = table.Column<string>(type: "TEXT", nullable: true),
                    Observacao = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medidas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medidas");
        }
    }
}
