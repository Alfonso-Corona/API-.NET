using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class FeedDataMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "Piscina", "Villa de lujo", new DateTime(2024, 3, 29, 20, 43, 54, 197, DateTimeKind.Local).AddTicks(8887), new DateTime(2024, 3, 29, 20, 43, 54, 197, DateTimeKind.Local).AddTicks(8876), "", 200, "Villa Real", 6, 1000.0 },
                    { 2, "", "Villa en otro lado", new DateTime(2024, 3, 29, 20, 43, 54, 197, DateTimeKind.Local).AddTicks(8893), new DateTime(2024, 3, 29, 20, 43, 54, 197, DateTimeKind.Local).AddTicks(8892), "", 30, "Villa Diferente", 2, 100.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
