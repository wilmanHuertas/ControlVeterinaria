using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace paginaprueba1.app.Migrations
{
    public partial class InitialDbMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "asistentes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    docVeterinaria = table.Column<decimal>(nullable: false),
                    docResponsable = table.Column<decimal>(nullable: false),
                    nombreResponsable = table.Column<string>(nullable: true),
                    telefono = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asistentes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "citas",
                columns: table => new
                {
                    idAgendaCita = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idMascota = table.Column<int>(nullable: false),
                    idVeterinario = table.Column<int>(nullable: false),
                    fechaHora = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_citas", x => x.idAgendaCita);
                });

            migrationBuilder.CreateTable(
                name: "mascotas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    docDueño = table.Column<decimal>(nullable: false),
                    nombreMascota = table.Column<string>(nullable: true),
                    edadMascota = table.Column<int>(nullable: false),
                    tipoMascota = table.Column<string>(nullable: true),
                    raza = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mascotas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    documento = table.Column<decimal>(nullable: false),
                    nombreCompleto = table.Column<string>(nullable: true),
                    telefono = table.Column<long>(nullable: false),
                    contraseña = table.Column<string>(nullable: true),
                    perfil = table.Column<string>(nullable: true),
                    correo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "veterinarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    docVeterinario = table.Column<long>(nullable: false),
                    numMatriProfesional = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veterinarios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "asistentes",
                columns: new[] { "Id", "docResponsable", "docVeterinaria", "nombreResponsable", "telefono" },
                values: new object[] { 1, 1001256489m, 1m, "Karen Daniela Ochoa Vasquez", 3164586231L });

            migrationBuilder.InsertData(
                table: "citas",
                columns: new[] { "idAgendaCita", "fechaHora", "idMascota", "idVeterinario" },
                values: new object[] { 1, new DateTime(2022, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.InsertData(
                table: "mascotas",
                columns: new[] { "Id", "docDueño", "edadMascota", "nombreMascota", "raza", "tipoMascota" },
                values: new object[] { 1, 1016526325m, 8, "verano", "Labrador", "Perro" });

            migrationBuilder.InsertData(
                table: "personas",
                columns: new[] { "Id", "contraseña", "correo", "documento", "nombreCompleto", "perfil", "telefono" },
                values: new object[,]
                {
                    { 1, "callefalsa123", "vet.mundoanimal@gmail.com", 1m, "Veterinaria Mundo Animal", "admin", 3194482143L },
                    { 2, "1234", "jorge_36@gmail.com", 4651289m, "Jorge Hernandez Cruz", "vet", 3102568465L },
                    { 3, "1234", "julianat@gmail.com", 1016526325m, "Juliana Torres Arango", "client", 3205641523L }
                });

            migrationBuilder.InsertData(
                table: "veterinarios",
                columns: new[] { "Id", "docVeterinario", "numMatriProfesional" },
                values: new object[] { 1, 4651289L, 1001256L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "asistentes");

            migrationBuilder.DropTable(
                name: "citas");

            migrationBuilder.DropTable(
                name: "mascotas");

            migrationBuilder.DropTable(
                name: "personas");

            migrationBuilder.DropTable(
                name: "veterinarios");
        }
    }
}
