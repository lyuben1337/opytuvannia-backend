using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace opytuvannia_backend.Migrations
{
    /// <inheritdoc />
    public partial class ChangedTaskToQuestion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_answers_tasks_survey_task_id",
                table: "answers");

            migrationBuilder.DropForeignKey(
                name: "fk_respondent_survey_answers_tasks_survey_task_id",
                table: "respondent_survey_answers");

            migrationBuilder.DropTable(
                name: "tasks");

            migrationBuilder.DropIndex(
                name: "ix_respondent_survey_answers_survey_task_id",
                table: "respondent_survey_answers");

            migrationBuilder.DropColumn(
                name: "survey_task_id",
                table: "respondent_survey_answers");

            migrationBuilder.RenameColumn(
                name: "survey_task_id",
                table: "answers",
                newName: "question_id");

            migrationBuilder.RenameIndex(
                name: "ix_answers_survey_task_id",
                table: "answers",
                newName: "ix_answers_question_id");

            migrationBuilder.AddColumn<string>(
                name: "question_id",
                table: "respondent_survey_answers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "questions",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    survey_id = table.Column<string>(type: "text", nullable: true),
                    title = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_questions", x => x.id);
                    table.ForeignKey(
                        name: "fk_questions_surveys_survey_id",
                        column: x => x.survey_id,
                        principalTable: "surveys",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "ix_respondent_survey_answers_question_id",
                table: "respondent_survey_answers",
                column: "question_id");

            migrationBuilder.CreateIndex(
                name: "ix_questions_survey_id",
                table: "questions",
                column: "survey_id");

            migrationBuilder.AddForeignKey(
                name: "fk_answers_questions_question_id",
                table: "answers",
                column: "question_id",
                principalTable: "questions",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_respondent_survey_answers_questions_question_id",
                table: "respondent_survey_answers",
                column: "question_id",
                principalTable: "questions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_answers_questions_question_id",
                table: "answers");

            migrationBuilder.DropForeignKey(
                name: "fk_respondent_survey_answers_questions_question_id",
                table: "respondent_survey_answers");

            migrationBuilder.DropTable(
                name: "questions");

            migrationBuilder.DropIndex(
                name: "ix_respondent_survey_answers_question_id",
                table: "respondent_survey_answers");

            migrationBuilder.DropColumn(
                name: "question_id",
                table: "respondent_survey_answers");

            migrationBuilder.RenameColumn(
                name: "question_id",
                table: "answers",
                newName: "survey_task_id");

            migrationBuilder.RenameIndex(
                name: "ix_answers_question_id",
                table: "answers",
                newName: "ix_answers_survey_task_id");

            migrationBuilder.AddColumn<string>(
                name: "survey_task_id",
                table: "respondent_survey_answers",
                type: "text",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "ix_respondent_survey_answers_survey_task_id",
                table: "respondent_survey_answers",
                column: "survey_task_id");

            migrationBuilder.CreateIndex(
                name: "ix_tasks_survey_id",
                table: "tasks",
                column: "survey_id");

            migrationBuilder.AddForeignKey(
                name: "fk_answers_tasks_survey_task_id",
                table: "answers",
                column: "survey_task_id",
                principalTable: "tasks",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_respondent_survey_answers_tasks_survey_task_id",
                table: "respondent_survey_answers",
                column: "survey_task_id",
                principalTable: "tasks",
                principalColumn: "id");
        }
    }
}
