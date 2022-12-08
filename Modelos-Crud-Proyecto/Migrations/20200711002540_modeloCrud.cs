using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Modelos_Crud_Proyecto.Migrations
{
    public partial class modeloCrud : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    CategoriaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 256, nullable: true),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.CategoriaID);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellidos = table.Column<string>(maxLength: 30, nullable: false),
                    Nombres = table.Column<string>(maxLength: 20, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Documento = table.Column<string>(maxLength: 15, nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Telefono = table.Column<string>(nullable: true),
                    DireccionPersona = table.Column<string>(maxLength: 100, nullable: true),
                    EstadoPersona = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    CursoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    CategoriaID = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(maxLength: 512, nullable: false),
                    Creditos = table.Column<int>(nullable: false),
                    Horas = table.Column<int>(nullable: false),
                    Costo = table.Column<int>(nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.CursoID);
                    table.ForeignKey(
                        name: "FK_Curso_Categoria_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categoria",
                        principalColumn: "CategoriaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Estudiante",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(maxLength: 20, nullable: false),
                    PersonaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiante", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Estudiante_Persona_PersonaID",
                        column: x => x.PersonaID,
                        principalTable: "Persona",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instructor",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Especialidad = table.Column<string>(maxLength: 30, nullable: false),
                    PersonaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Instructor_Persona_PersonaID",
                        column: x => x.PersonaID,
                        principalTable: "Persona",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inscripcion",
                columns: table => new
                {
                    InscripcionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grado = table.Column<int>(nullable: false),
                    CursoID = table.Column<int>(nullable: false),
                    EstudianteID = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Pago = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscripcion", x => x.InscripcionID);
                    table.ForeignKey(
                        name: "FK_Inscripcion_Curso_CursoID",
                        column: x => x.CursoID,
                        principalTable: "Curso",
                        principalColumn: "CursoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inscripcion_Estudiante_EstudianteID",
                        column: x => x.EstudianteID,
                        principalTable: "Estudiante",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Asignacion",
                columns: table => new
                {
                    AsignacionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CursoID = table.Column<int>(nullable: false),
                    InstructorID = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignacion", x => x.AsignacionID);
                    table.ForeignKey(
                        name: "FK_Asignacion_Curso_CursoID",
                        column: x => x.CursoID,
                        principalTable: "Curso",
                        principalColumn: "CursoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Asignacion_Instructor_InstructorID",
                        column: x => x.InstructorID,
                        principalTable: "Instructor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asignacion_CursoID",
                table: "Asignacion",
                column: "CursoID");

            migrationBuilder.CreateIndex(
                name: "IX_Asignacion_InstructorID",
                table: "Asignacion",
                column: "InstructorID");

            migrationBuilder.CreateIndex(
                name: "IX_Curso_CategoriaID",
                table: "Curso",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiante_PersonaID",
                table: "Estudiante",
                column: "PersonaID");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripcion_CursoID",
                table: "Inscripcion",
                column: "CursoID");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripcion_EstudianteID",
                table: "Inscripcion",
                column: "EstudianteID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_PersonaID",
                table: "Instructor",
                column: "PersonaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asignacion");

            migrationBuilder.DropTable(
                name: "Inscripcion");

            migrationBuilder.DropTable(
                name: "Instructor");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Estudiante");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Persona");
        }
    }
}
