using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoForms.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoDaModelFormulario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Formulario",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Formulario",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataAtualizacao",
                table: "Formulario");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Formulario");
        }
    }
}
