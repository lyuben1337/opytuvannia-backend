using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace opytuvannia_backend.Migrations
{
    /// <inheritdoc />
    public partial class SurveysMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "companies",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    logo_src = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_companies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "surveys",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    title = table.Column<string>(type: "text", nullable: false),
                    company_id = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    reward = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_surveys", x => x.id);
                    table.ForeignKey(
                        name: "fk_surveys_companies_company_id",
                        column: x => x.company_id,
                        principalTable: "companies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "respondent_surveys",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    respondent_id = table.Column<string>(type: "character varying(36)", nullable: false),
                    survey_id = table.Column<string>(type: "text", nullable: true),
                    completion_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_respondent_surveys", x => x.id);
                    table.ForeignKey(
                        name: "fk_respondent_surveys_respondents_respondent_id",
                        column: x => x.respondent_id,
                        principalTable: "respondents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_respondent_surveys_surveys_survey_id",
                        column: x => x.survey_id,
                        principalTable: "surveys",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "tasks",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    survey_id = table.Column<string>(type: "text", nullable: false),
                    title = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tasks", x => x.id);
                    table.ForeignKey(
                        name: "fk_tasks_surveys_survey_id",
                        column: x => x.survey_id,
                        principalTable: "surveys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "answers",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    survey_task_id = table.Column<string>(type: "text", nullable: true),
                    content = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_answers", x => x.id);
                    table.ForeignKey(
                        name: "fk_answers_tasks_survey_task_id",
                        column: x => x.survey_task_id,
                        principalTable: "tasks",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "respondent_survey_answers",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    respondent_survey_id = table.Column<string>(type: "text", nullable: true),
                    survey_task_id = table.Column<string>(type: "text", nullable: true),
                    answer_id = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_respondent_survey_answers", x => x.id);
                    table.ForeignKey(
                        name: "fk_respondent_survey_answers_answers_answer_id",
                        column: x => x.answer_id,
                        principalTable: "answers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_respondent_survey_answers_respondent_surveys_respondent_sur",
                        column: x => x.respondent_survey_id,
                        principalTable: "respondent_surveys",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_respondent_survey_answers_tasks_survey_task_id",
                        column: x => x.survey_task_id,
                        principalTable: "tasks",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "ix_answers_survey_task_id",
                table: "answers",
                column: "survey_task_id");

            migrationBuilder.CreateIndex(
                name: "ix_respondent_survey_answers_answer_id",
                table: "respondent_survey_answers",
                column: "answer_id");

            migrationBuilder.CreateIndex(
                name: "ix_respondent_survey_answers_respondent_survey_id",
                table: "respondent_survey_answers",
                column: "respondent_survey_id");

            migrationBuilder.CreateIndex(
                name: "ix_respondent_survey_answers_survey_task_id",
                table: "respondent_survey_answers",
                column: "survey_task_id");

            migrationBuilder.CreateIndex(
                name: "ix_respondent_surveys_respondent_id",
                table: "respondent_surveys",
                column: "respondent_id");

            migrationBuilder.CreateIndex(
                name: "ix_respondent_surveys_survey_id",
                table: "respondent_surveys",
                column: "survey_id");

            migrationBuilder.CreateIndex(
                name: "ix_surveys_company_id",
                table: "surveys",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "ix_tasks_survey_id",
                table: "tasks",
                column: "survey_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "respondent_survey_answers");

            migrationBuilder.DropTable(
                name: "answers");

            migrationBuilder.DropTable(
                name: "respondent_surveys");

            migrationBuilder.DropTable(
                name: "tasks");

            migrationBuilder.DropTable(
                name: "surveys");

            migrationBuilder.DropTable(
                name: "companies");
        }
    }
}
