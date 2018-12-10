using Microsoft.EntityFrameworkCore.Migrations;

namespace INRAMVCDatPredWebCore.Migrations
{
    public partial class Doce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carpeta_Departamento_DepartamentoId",
                table: "Carpeta");

            migrationBuilder.DropForeignKey(
                name: "FK_Carpeta_Users_Id",
                table: "Carpeta");

            migrationBuilder.DropForeignKey(
                name: "FK_Carpeta_Municipio_MunicipioId",
                table: "Carpeta");

            migrationBuilder.DropForeignKey(
                name: "FK_Carpeta_Provincia_ProvinciaId",
                table: "Carpeta");

            migrationBuilder.DropForeignKey(
                name: "FK_Carpeta_Ubicacion_UbicacionId",
                table: "Carpeta");

            migrationBuilder.DropForeignKey(
                name: "FK_Municipio_Provincia_ProvinciaId",
                table: "Municipio");

            migrationBuilder.DropForeignKey(
                name: "FK_Provincia_Departamento_DepartamentoId",
                table: "Provincia");

            migrationBuilder.DropForeignKey(
                name: "FK_Resolucion_Users_Id",
                table: "Resolucion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ubicacion",
                table: "Ubicacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Resolucion",
                table: "Resolucion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provincia",
                table: "Provincia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Municipio",
                table: "Municipio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departamento",
                table: "Departamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carpeta",
                table: "Carpeta");

            migrationBuilder.RenameTable(
                name: "Ubicacion",
                newName: "Ubicaciones");

            migrationBuilder.RenameTable(
                name: "Resolucion",
                newName: "Resoluciones");

            migrationBuilder.RenameTable(
                name: "Provincia",
                newName: "Provincias");

            migrationBuilder.RenameTable(
                name: "Municipio",
                newName: "Municipios");

            migrationBuilder.RenameTable(
                name: "Departamento",
                newName: "Departamentos");

            migrationBuilder.RenameTable(
                name: "Carpeta",
                newName: "Carpetas");

            migrationBuilder.RenameIndex(
                name: "IX_Resolucion_Id",
                table: "Resoluciones",
                newName: "IX_Resoluciones_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Provincia_DepartamentoId",
                table: "Provincias",
                newName: "IX_Provincias_DepartamentoId");

            migrationBuilder.RenameIndex(
                name: "IX_Municipio_ProvinciaId",
                table: "Municipios",
                newName: "IX_Municipios_ProvinciaId");

            migrationBuilder.RenameIndex(
                name: "IX_Carpeta_UbicacionId",
                table: "Carpetas",
                newName: "IX_Carpetas_UbicacionId");

            migrationBuilder.RenameIndex(
                name: "IX_Carpeta_ProvinciaId",
                table: "Carpetas",
                newName: "IX_Carpetas_ProvinciaId");

            migrationBuilder.RenameIndex(
                name: "IX_Carpeta_MunicipioId",
                table: "Carpetas",
                newName: "IX_Carpetas_MunicipioId");

            migrationBuilder.RenameIndex(
                name: "IX_Carpeta_Id",
                table: "Carpetas",
                newName: "IX_Carpetas_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Carpeta_DepartamentoId",
                table: "Carpetas",
                newName: "IX_Carpetas_DepartamentoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ubicaciones",
                table: "Ubicaciones",
                column: "UbicacionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Resoluciones",
                table: "Resoluciones",
                column: "ResolcuionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provincias",
                table: "Provincias",
                column: "ProvinciaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Municipios",
                table: "Municipios",
                column: "MunicipioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departamentos",
                table: "Departamentos",
                column: "DepartamentoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carpetas",
                table: "Carpetas",
                column: "CarpetaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carpetas_Departamentos_DepartamentoId",
                table: "Carpetas",
                column: "DepartamentoId",
                principalTable: "Departamentos",
                principalColumn: "DepartamentoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carpetas_Users_Id",
                table: "Carpetas",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carpetas_Municipios_MunicipioId",
                table: "Carpetas",
                column: "MunicipioId",
                principalTable: "Municipios",
                principalColumn: "MunicipioId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carpetas_Provincias_ProvinciaId",
                table: "Carpetas",
                column: "ProvinciaId",
                principalTable: "Provincias",
                principalColumn: "ProvinciaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carpetas_Ubicaciones_UbicacionId",
                table: "Carpetas",
                column: "UbicacionId",
                principalTable: "Ubicaciones",
                principalColumn: "UbicacionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Municipios_Provincias_ProvinciaId",
                table: "Municipios",
                column: "ProvinciaId",
                principalTable: "Provincias",
                principalColumn: "ProvinciaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Provincias_Departamentos_DepartamentoId",
                table: "Provincias",
                column: "DepartamentoId",
                principalTable: "Departamentos",
                principalColumn: "DepartamentoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resoluciones_Users_Id",
                table: "Resoluciones",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carpetas_Departamentos_DepartamentoId",
                table: "Carpetas");

            migrationBuilder.DropForeignKey(
                name: "FK_Carpetas_Users_Id",
                table: "Carpetas");

            migrationBuilder.DropForeignKey(
                name: "FK_Carpetas_Municipios_MunicipioId",
                table: "Carpetas");

            migrationBuilder.DropForeignKey(
                name: "FK_Carpetas_Provincias_ProvinciaId",
                table: "Carpetas");

            migrationBuilder.DropForeignKey(
                name: "FK_Carpetas_Ubicaciones_UbicacionId",
                table: "Carpetas");

            migrationBuilder.DropForeignKey(
                name: "FK_Municipios_Provincias_ProvinciaId",
                table: "Municipios");

            migrationBuilder.DropForeignKey(
                name: "FK_Provincias_Departamentos_DepartamentoId",
                table: "Provincias");

            migrationBuilder.DropForeignKey(
                name: "FK_Resoluciones_Users_Id",
                table: "Resoluciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ubicaciones",
                table: "Ubicaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Resoluciones",
                table: "Resoluciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provincias",
                table: "Provincias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Municipios",
                table: "Municipios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departamentos",
                table: "Departamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carpetas",
                table: "Carpetas");

            migrationBuilder.RenameTable(
                name: "Ubicaciones",
                newName: "Ubicacion");

            migrationBuilder.RenameTable(
                name: "Resoluciones",
                newName: "Resolucion");

            migrationBuilder.RenameTable(
                name: "Provincias",
                newName: "Provincia");

            migrationBuilder.RenameTable(
                name: "Municipios",
                newName: "Municipio");

            migrationBuilder.RenameTable(
                name: "Departamentos",
                newName: "Departamento");

            migrationBuilder.RenameTable(
                name: "Carpetas",
                newName: "Carpeta");

            migrationBuilder.RenameIndex(
                name: "IX_Resoluciones_Id",
                table: "Resolucion",
                newName: "IX_Resolucion_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Provincias_DepartamentoId",
                table: "Provincia",
                newName: "IX_Provincia_DepartamentoId");

            migrationBuilder.RenameIndex(
                name: "IX_Municipios_ProvinciaId",
                table: "Municipio",
                newName: "IX_Municipio_ProvinciaId");

            migrationBuilder.RenameIndex(
                name: "IX_Carpetas_UbicacionId",
                table: "Carpeta",
                newName: "IX_Carpeta_UbicacionId");

            migrationBuilder.RenameIndex(
                name: "IX_Carpetas_ProvinciaId",
                table: "Carpeta",
                newName: "IX_Carpeta_ProvinciaId");

            migrationBuilder.RenameIndex(
                name: "IX_Carpetas_MunicipioId",
                table: "Carpeta",
                newName: "IX_Carpeta_MunicipioId");

            migrationBuilder.RenameIndex(
                name: "IX_Carpetas_Id",
                table: "Carpeta",
                newName: "IX_Carpeta_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Carpetas_DepartamentoId",
                table: "Carpeta",
                newName: "IX_Carpeta_DepartamentoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ubicacion",
                table: "Ubicacion",
                column: "UbicacionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Resolucion",
                table: "Resolucion",
                column: "ResolcuionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provincia",
                table: "Provincia",
                column: "ProvinciaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Municipio",
                table: "Municipio",
                column: "MunicipioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departamento",
                table: "Departamento",
                column: "DepartamentoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carpeta",
                table: "Carpeta",
                column: "CarpetaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carpeta_Departamento_DepartamentoId",
                table: "Carpeta",
                column: "DepartamentoId",
                principalTable: "Departamento",
                principalColumn: "DepartamentoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carpeta_Users_Id",
                table: "Carpeta",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carpeta_Municipio_MunicipioId",
                table: "Carpeta",
                column: "MunicipioId",
                principalTable: "Municipio",
                principalColumn: "MunicipioId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carpeta_Provincia_ProvinciaId",
                table: "Carpeta",
                column: "ProvinciaId",
                principalTable: "Provincia",
                principalColumn: "ProvinciaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carpeta_Ubicacion_UbicacionId",
                table: "Carpeta",
                column: "UbicacionId",
                principalTable: "Ubicacion",
                principalColumn: "UbicacionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Municipio_Provincia_ProvinciaId",
                table: "Municipio",
                column: "ProvinciaId",
                principalTable: "Provincia",
                principalColumn: "ProvinciaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Provincia_Departamento_DepartamentoId",
                table: "Provincia",
                column: "DepartamentoId",
                principalTable: "Departamento",
                principalColumn: "DepartamentoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resolucion_Users_Id",
                table: "Resolucion",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
