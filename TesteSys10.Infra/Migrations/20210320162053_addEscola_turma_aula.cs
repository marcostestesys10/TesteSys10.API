using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteSys10.Infra.Migrations
{
    public partial class addEscola_turma_aula : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Perfis_PerfilId",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "PerfilId",
                table: "Usuarios",
                newName: "PerfilIdPerfil");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Usuarios",
                newName: "IdUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_PerfilId",
                table: "Usuarios",
                newName: "IX_Usuarios_PerfilIdPerfil");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Perfis",
                newName: "IdPerfil");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Perfis_PerfilIdPerfil",
                table: "Usuarios",
                column: "PerfilIdPerfil",
                principalTable: "Perfis",
                principalColumn: "IdPerfil",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Perfis_PerfilIdPerfil",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "PerfilIdPerfil",
                table: "Usuarios",
                newName: "PerfilId");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Usuarios",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_PerfilIdPerfil",
                table: "Usuarios",
                newName: "IX_Usuarios_PerfilId");

            migrationBuilder.RenameColumn(
                name: "IdPerfil",
                table: "Perfis",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Perfis_PerfilId",
                table: "Usuarios",
                column: "PerfilId",
                principalTable: "Perfis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
