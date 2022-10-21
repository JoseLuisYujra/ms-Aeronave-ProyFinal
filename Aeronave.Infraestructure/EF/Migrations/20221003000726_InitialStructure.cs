using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aeronaves.Infraestructure.EF.Migrations {
  public partial class InitialStructure : Migration {
    protected override void Up(MigrationBuilder migrationBuilder) {
      migrationBuilder.CreateTable(
          name: "Aeronave",
          columns: table => new {
            Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            CodAeronave = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            Marca = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            Modelo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            NroAsientos = table.Column<int>(type: "int", nullable: false),
            CapacidadCarga = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
            CapTanqueCombustible = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
            AereopuertoEstacionamiento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            EstadoAeronave = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
          },
          constraints: table => {
            table.PrimaryKey("PK_Aeronave", x => x.Id);
          });

      migrationBuilder.CreateTable(
          name: "AeronaveAsientos",
          columns: table => new {
            Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            AeronaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            ClaseAsiento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            Ubicacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            NroSilla = table.Column<int>(type: "int", nullable: false),
            EstadoAsiento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
          },
          constraints: table => {
            table.PrimaryKey("PK_AeronaveAsientos", x => x.Id);
            table.ForeignKey(
                      name: "FK_AeronaveAsientos_Aeronave_AeronaveId",
                      column: x => x.AeronaveId,
                      principalTable: "Aeronave",
                      principalColumn: "Id",
                      onDelete: ReferentialAction.Cascade);
          });

      migrationBuilder.CreateIndex(
          name: "IX_AeronaveAsientos_AeronaveId",
          table: "AeronaveAsientos",
          column: "AeronaveId");
    }

    protected override void Down(MigrationBuilder migrationBuilder) {
      migrationBuilder.DropTable(
          name: "AeronaveAsientos");

      migrationBuilder.DropTable(
          name: "Aeronave");
    }
  }
}
