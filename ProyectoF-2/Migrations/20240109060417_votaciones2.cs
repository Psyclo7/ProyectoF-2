using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoF_2.Migrations
{
    /// <inheritdoc />
    public partial class votaciones2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    id_usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    documento_identidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre_usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido_usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    correo_usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    clave_usuario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.id_usuario);
                });

            migrationBuilder.CreateTable(
                name: "Elecciones",
                columns: table => new
                {
                    id_eleccion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha_registro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_usuario = table.Column<int>(type: "int", nullable: false),
                    Usuarioid_usuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elecciones", x => x.id_eleccion);
                    table.ForeignKey(
                        name: "FK_Elecciones_Usuarios_Usuarioid_usuario",
                        column: x => x.Usuarioid_usuario,
                        principalTable: "Usuarios",
                        principalColumn: "id_usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Candidatos",
                columns: table => new
                {
                    id_candidato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_candidato = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mensaje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_eleccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eleccionid_eleccion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidatos", x => x.id_candidato);
                    table.ForeignKey(
                        name: "FK_Candidatos_Elecciones_Eleccionid_eleccion",
                        column: x => x.Eleccionid_eleccion,
                        principalTable: "Elecciones",
                        principalColumn: "id_eleccion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Votaciones",
                columns: table => new
                {
                    id_votacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha_votacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_candidato = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Candidatoid_candidato = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votaciones", x => x.id_votacion);
                    table.ForeignKey(
                        name: "FK_Votaciones_Candidatos_Candidatoid_candidato",
                        column: x => x.Candidatoid_candidato,
                        principalTable: "Candidatos",
                        principalColumn: "id_candidato",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidatos_Eleccionid_eleccion",
                table: "Candidatos",
                column: "Eleccionid_eleccion");

            migrationBuilder.CreateIndex(
                name: "IX_Elecciones_Usuarioid_usuario",
                table: "Elecciones",
                column: "Usuarioid_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Votaciones_Candidatoid_candidato",
                table: "Votaciones",
                column: "Candidatoid_candidato");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Votaciones");

            migrationBuilder.DropTable(
                name: "Candidatos");

            migrationBuilder.DropTable(
                name: "Elecciones");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
