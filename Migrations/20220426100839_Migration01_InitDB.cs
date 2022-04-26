using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DevoirRest.Migrations
{
    public partial class Migration01_InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "core_t_course",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    teacher_id = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    update_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_core_t_course", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "core_t_student",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    matricule = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    update_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_core_t_student", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "core_t_home_work",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    course_id = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    update_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_core_t_home_work", x => x.id);
                    table.ForeignKey(
                        name: "FK_core_t_home_work_core_t_course_course_id",
                        column: x => x.course_id,
                        principalTable: "core_t_course",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "core_t_teacher",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    course_id = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    update_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_core_t_teacher", x => x.id);
                    table.ForeignKey(
                        name: "FK_core_t_teacher_core_t_course_course_id",
                        column: x => x.course_id,
                        principalTable: "core_t_course",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "core_tj_enrollement",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    course_id = table.Column<int>(type: "integer", nullable: false),
                    student_id = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    update_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_core_tj_enrollement", x => x.id);
                    table.ForeignKey(
                        name: "FK_core_tj_enrollement_core_t_course_course_id",
                        column: x => x.course_id,
                        principalTable: "core_t_course",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_core_tj_enrollement_core_t_student_student_id",
                        column: x => x.student_id,
                        principalTable: "core_t_student",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "core_t_comment",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    home_work_id = table.Column<int>(type: "integer", nullable: false),
                    teacher_id = table.Column<int>(type: "integer", nullable: true),
                    student_id = table.Column<int>(type: "integer", nullable: true),
                    code = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    update_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_core_t_comment", x => x.id);
                    table.ForeignKey(
                        name: "FK_core_t_comment_core_t_home_work_home_work_id",
                        column: x => x.home_work_id,
                        principalTable: "core_t_home_work",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_core_t_comment_core_t_student_student_id",
                        column: x => x.student_id,
                        principalTable: "core_t_student",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_core_t_comment_core_t_teacher_teacher_id",
                        column: x => x.teacher_id,
                        principalTable: "core_t_teacher",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_core_t_comment_home_work_id",
                table: "core_t_comment",
                column: "home_work_id");

            migrationBuilder.CreateIndex(
                name: "IX_core_t_comment_student_id",
                table: "core_t_comment",
                column: "student_id");

            migrationBuilder.CreateIndex(
                name: "IX_core_t_comment_teacher_id",
                table: "core_t_comment",
                column: "teacher_id");

            migrationBuilder.CreateIndex(
                name: "IX_core_t_home_work_course_id",
                table: "core_t_home_work",
                column: "course_id");

            migrationBuilder.CreateIndex(
                name: "IX_core_t_teacher_course_id",
                table: "core_t_teacher",
                column: "course_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_core_tj_enrollement_course_id",
                table: "core_tj_enrollement",
                column: "course_id");

            migrationBuilder.CreateIndex(
                name: "IX_core_tj_enrollement_student_id",
                table: "core_tj_enrollement",
                column: "student_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "core_t_comment");

            migrationBuilder.DropTable(
                name: "core_tj_enrollement");

            migrationBuilder.DropTable(
                name: "core_t_home_work");

            migrationBuilder.DropTable(
                name: "core_t_teacher");

            migrationBuilder.DropTable(
                name: "core_t_student");

            migrationBuilder.DropTable(
                name: "core_t_course");
        }
    }
}
