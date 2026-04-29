using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "FotoPersonagem",
                table: "TB_PERSONAGENS",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TB_USUARIOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usernme = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    latitude = table.Column<double>(type: "float", nullable: true),
                    longitude = table.Column<double>(type: "float", nullable: true),
                    DataAcesso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Perfil = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, defaultValue: "Jogador"),
                    Email = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USUARIOS", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, 1 });

            migrationBuilder.InsertData(
                table: "TB_USUARIOS",
                columns: new[] { "Id", "DataAcesso", "Email", "Foto", "PasswordHash", "PasswordSalt", "Perfil", "Usernme", "latitude", "longitude" },
                values: new object[] { 1, null, "seuEmail@gmail.com", null, new byte[] { 24, 77, 191, 63, 196, 26, 2, 16, 84, 94, 11, 109, 194, 255, 65, 145, 203, 170, 193, 237, 88, 207, 11, 48, 3, 182, 99, 113, 254, 199, 219, 75, 146, 180, 44, 168, 73, 246, 23, 52, 142, 250, 21, 230, 73, 10, 63, 21, 181, 127, 62, 212, 51, 193, 56, 111, 244, 10, 224, 145, 69, 109, 13, 157 }, new byte[] { 200, 199, 75, 164, 40, 195, 163, 79, 9, 113, 154, 101, 219, 92, 132, 134, 48, 248, 227, 25, 222, 210, 223, 229, 237, 9, 240, 242, 41, 74, 150, 114, 96, 143, 35, 197, 171, 164, 103, 179, 177, 241, 96, 251, 78, 29, 105, 43, 93, 93, 166, 129, 148, 46, 178, 20, 88, 109, 253, 99, 206, 254, 27, 60, 12, 243, 20, 240, 252, 82, 135, 217, 57, 159, 20, 248, 22, 141, 30, 244, 201, 219, 187, 31, 192, 86, 121, 74, 251, 166, 141, 132, 98, 204, 173, 134, 234, 124, 167, 66, 180, 39, 125, 79, 212, 183, 60, 124, 67, 243, 181, 10, 3, 91, 62, 64, 103, 219, 1, 46, 83, 31, 250, 90, 159, 169, 110, 102 }, "Admin", "UsuarioAdmin", -23.520024100000001, -46.596497999999997 });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_UsuarioId",
                table: "TB_PERSONAGENS",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PERSONAGENS_TB_USUARIOS_UsuarioId",
                table: "TB_PERSONAGENS",
                column: "UsuarioId",
                principalTable: "TB_USUARIOS",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_PERSONAGENS_TB_USUARIOS_UsuarioId",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropTable(
                name: "TB_USUARIOS");

            migrationBuilder.DropIndex(
                name: "IX_TB_PERSONAGENS_UsuarioId",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "FotoPersonagem",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "TB_PERSONAGENS");
        }
    }
}
