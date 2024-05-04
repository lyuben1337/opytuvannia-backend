using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace opytuvannia_backend.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_answers_questions_question_id",
                table: "answers");

            migrationBuilder.DropForeignKey(
                name: "fk_questions_surveys_survey_id",
                table: "questions");

            migrationBuilder.DropForeignKey(
                name: "fk_respondent_survey_answers_respondent_surveys_respondent_sur",
                table: "respondent_survey_answers");

            migrationBuilder.DropForeignKey(
                name: "fk_respondent_surveys_surveys_survey_id",
                table: "respondent_surveys");

            migrationBuilder.AlterColumn<string>(
                name: "survey_id",
                table: "respondent_surveys",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "respondent_survey_id",
                table: "respondent_survey_answers",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "survey_id",
                table: "questions",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "question_id",
                table: "answers",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "companies",
                columns: new[] { "id", "logo_src", "name" },
                values: new object[,]
                {
                    { "729e7118-9994-4318-9ca0-84a3d3ff3a67", "https://cdn.metro-online.com/-/media/Project/MCW/RU_Metro/2021/join-us/Metro.png?rev=fe69769d14aa4105bc7e5731e32ebfc7&w=339&hash=783A0BB0789E586BB438C44B0778558A", "Metro" },
                    { "9f18a11d-d392-48e3-87eb-916536aa49d4", "https://allretail.ua/static/files/originals/2/85/30b01f786bd9a28d98e745247184f852.svg", "АТБ" },
                    { "d56e3b51-f341-49f6-b803-0fb8494e01d0", "https://silpo.ua/images/silpo_fb_share.png", "Сільпо" }
                });

            migrationBuilder.InsertData(
                table: "surveys",
                columns: new[] { "id", "company_id", "description", "reward", "title" },
                values: new object[,]
                {
                    { "2a5c430e-6c91-41a8-840c-745b14c3e430", "9f18a11d-d392-48e3-87eb-916536aa49d4", "Щоб покращити обслуговування, просимо вас взяти участь в нашому опитуванні", "Знижка 10% на наступну покупку", "Ваші покупки в АТБ" },
                    { "66908dd3-7431-4742-b97b-35419aeaf7ad", "d56e3b51-f341-49f6-b803-0fb8494e01d0", "Опитування про ваші уподобання щодо пива", "Промокод -50% на чернігівське титан zxcqw-e13371000-7wwww", "Споживання пива" },
                    { "af8ffc99-ab31-4d32-8252-1c27b9756858", "729e7118-9994-4318-9ca0-84a3d3ff3a67", "Допоможіть нам визначити найпопулярніший продукт в Metro", "+100 грн", "Найкращий продукт" },
                    { "c6d37fbc-d07b-40c6-9a84-6214326d753c", "9f18a11d-d392-48e3-87eb-916536aa49d4", "Оцініть якість обслуговування в наших магазинах", "Безкоштовна доставка при наступному замовленні", "Якість обслуговування" }
                });

            migrationBuilder.InsertData(
                table: "questions",
                columns: new[] { "id", "survey_id", "title" },
                values: new object[,]
                {
                    { "047902f0-b550-4fa5-a260-feff9279373f", "2a5c430e-6c91-41a8-840c-745b14c3e430", "Чи вважаєте ви наші ціни конкурентоспроможними?" },
                    { "0edc0aab-65bc-4998-95d7-859c5e751c98", "c6d37fbc-d07b-40c6-9a84-6214326d753c", "Як ви оцінюєте чистоту наших магазинів?" },
                    { "16c428ac-43d2-4396-9c2d-ee2e1e946073", "66908dd3-7431-4742-b97b-35419aeaf7ad", "Як часто ви купуєте пиво в наших магазинах?" },
                    { "2191f4e8-a7ba-45e3-8d41-da61ef25b873", "c6d37fbc-d07b-40c6-9a84-6214326d753c", "Чи вважаєте ви, що у нас завжди є необхідні товари?" },
                    { "2bb4699a-d432-4e51-bdd8-24f0089d5d3d", "2a5c430e-6c91-41a8-840c-745b14c3e430", "Як часто ви здійснюєте покупки в АТБ?" },
                    { "6afd4273-4755-4a70-8452-ed2e79652000", "2a5c430e-6c91-41a8-840c-745b14c3e430", "Які товари ви найчастіше купуєте в наших магазинах?" },
                    { "7b49c63d-379f-47bb-bb8a-8afa2586c8eb", "c6d37fbc-d07b-40c6-9a84-6214326d753c", "Чи допомагає вам персонал з пошуком товарів?" },
                    { "b781678a-de34-458b-a5d2-1e23d86a6484", "2a5c430e-6c91-41a8-840c-745b14c3e430", "Чи задоволені ви якістю обслуговування у наших магазинах?" },
                    { "b7f124bc-d583-4320-bd8c-186d57973a84", "66908dd3-7431-4742-b97b-35419aeaf7ad", "Які характеристики пива важливі для вас?" },
                    { "c43dbe6d-5571-448b-af78-58a68529c8c5", "af8ffc99-ab31-4d32-8252-1c27b9756858", "Чи задоволені ви асортиментом товарів у наших магазинах?" },
                    { "c9baf7e5-ebb9-4498-adc7-6e87990d2636", "c6d37fbc-d07b-40c6-9a84-6214326d753c", "Чи радите ви своїм знайомим відвідувати магазини АТБ?" },
                    { "caa62caf-160e-4ddc-8628-d144637c731e", "af8ffc99-ab31-4d32-8252-1c27b9756858", "Який продукт ви купуєте найчастіше в Metro?" },
                    { "cf9cbbdd-b0d4-4249-a600-8073451054e5", "af8ffc99-ab31-4d32-8252-1c27b9756858", "Як часто ви відвідуєте наші магазини?" },
                    { "d94492ca-4cea-411b-94ca-669b723bd426", "66908dd3-7431-4742-b97b-35419aeaf7ad", "Яке пиво ви купуєте найчастіше?" },
                    { "f846dae9-d25b-496b-85bf-7683b2e0e7cc", "66908dd3-7431-4742-b97b-35419aeaf7ad", "Чи спробували ви нові сорти пива в нашому магазині?" },
                    { "fae45801-2c7a-47ae-88f0-9998116409cb", "af8ffc99-ab31-4d32-8252-1c27b9756858", "Які характеристики товарів важливі для вас при покупці?" }
                });

            migrationBuilder.InsertData(
                table: "answers",
                columns: new[] { "id", "content", "question_id" },
                values: new object[,]
                {
                    { "0a07d221-6866-4674-abc3-f3390aa7345a", "Відповідь 95", "fae45801-2c7a-47ae-88f0-9998116409cb" },
                    { "0b0cffbd-4f4a-432e-a66f-7d1f140738b6", "Відповідь 28", "b781678a-de34-458b-a5d2-1e23d86a6484" },
                    { "0b264823-305f-471d-9d7e-92e3fc9b937d", "Відповідь 31", "c43dbe6d-5571-448b-af78-58a68529c8c5" },
                    { "10e3f030-53e2-42d3-8fce-d943d1c3a276", "Відповідь 18", "c9baf7e5-ebb9-4498-adc7-6e87990d2636" },
                    { "1a3d4422-13b4-41c1-8d52-4f70d00f2648", "Відповідь 10", "7b49c63d-379f-47bb-bb8a-8afa2586c8eb" },
                    { "1d93ade1-13b1-40c8-9731-542307d4ef56", "Відповідь 39", "c9baf7e5-ebb9-4498-adc7-6e87990d2636" },
                    { "1e93ad94-c71e-4f4e-b352-efccce5b2467", "Відповідь 85", "fae45801-2c7a-47ae-88f0-9998116409cb" },
                    { "1fae2821-d7ec-4376-be5f-52afaa42d23b", "Відповідь 28", "b7f124bc-d583-4320-bd8c-186d57973a84" },
                    { "23e6e7b3-7d88-4fc9-88e6-d013373bb8ec", "Відповідь 44", "16c428ac-43d2-4396-9c2d-ee2e1e946073" },
                    { "24d06306-e402-4bd7-a853-155bbcf2992b", "Відповідь 33", "c43dbe6d-5571-448b-af78-58a68529c8c5" },
                    { "3325ea8e-409c-4f73-a051-56dd5f226d66", "Відповідь 4", "caa62caf-160e-4ddc-8628-d144637c731e" },
                    { "34b9a264-42d8-42b1-9a95-f19daa8ff998", "Відповідь 67", "d94492ca-4cea-411b-94ca-669b723bd426" },
                    { "355bac16-3086-4403-955c-6910e31de947", "Відповідь 91", "2bb4699a-d432-4e51-bdd8-24f0089d5d3d" },
                    { "376555f6-395e-4b8a-a6b2-2e22ced7ac2a", "Відповідь 19", "fae45801-2c7a-47ae-88f0-9998116409cb" },
                    { "39aca928-10e4-4ec0-b756-54f036e20a95", "Відповідь 30", "047902f0-b550-4fa5-a260-feff9279373f" },
                    { "40d66e60-1664-43fa-a4c3-ce3deb7af848", "Відповідь 20", "7b49c63d-379f-47bb-bb8a-8afa2586c8eb" },
                    { "4329f923-e9da-4ad5-9b86-a7aaa7a66ee9", "Відповідь 75", "d94492ca-4cea-411b-94ca-669b723bd426" },
                    { "4df47b6d-cab5-4ae4-bd40-7dccd18efda2", "Відповідь 97", "fae45801-2c7a-47ae-88f0-9998116409cb" },
                    { "52635b69-8da4-4d44-8d13-46613c43bb43", "Відповідь 38", "2191f4e8-a7ba-45e3-8d41-da61ef25b873" },
                    { "5556316a-b00f-4843-84a3-4060a4f33e7f", "Відповідь 54", "c9baf7e5-ebb9-4498-adc7-6e87990d2636" },
                    { "58ba565e-ea3a-459d-8f75-0e9e1ae39e6d", "Відповідь 76", "16c428ac-43d2-4396-9c2d-ee2e1e946073" },
                    { "5c0349dd-7445-4162-839b-62dcff8a3567", "Відповідь 6", "2bb4699a-d432-4e51-bdd8-24f0089d5d3d" },
                    { "5ff93ade-dfb5-437a-8739-d6e778b73fc7", "Відповідь 66", "caa62caf-160e-4ddc-8628-d144637c731e" },
                    { "6529135e-1ff3-44f1-aaff-6f4111465faa", "Відповідь 28", "f846dae9-d25b-496b-85bf-7683b2e0e7cc" },
                    { "663bde69-3663-448b-a357-f11ed086266a", "Відповідь 20", "c43dbe6d-5571-448b-af78-58a68529c8c5" },
                    { "686e8897-ea89-4b5f-9317-a6cf508f01d9", "Відповідь 88", "2191f4e8-a7ba-45e3-8d41-da61ef25b873" },
                    { "6a7469cb-79c5-42d4-af7e-eac1528c5b58", "Відповідь 89", "c9baf7e5-ebb9-4498-adc7-6e87990d2636" },
                    { "71bfa9ac-d166-49a2-b169-392ce8a7c0f2", "Відповідь 36", "cf9cbbdd-b0d4-4249-a600-8073451054e5" },
                    { "7385d718-4619-44a6-a458-5a792ff084df", "Відповідь 72", "7b49c63d-379f-47bb-bb8a-8afa2586c8eb" },
                    { "7c725aeb-38b1-4ae9-8bbe-972e3d061cee", "Відповідь 29", "b781678a-de34-458b-a5d2-1e23d86a6484" },
                    { "81ba4a7f-a913-4f34-9e1b-b95056a7e4a2", "Відповідь 89", "2191f4e8-a7ba-45e3-8d41-da61ef25b873" },
                    { "862378db-6659-4641-a13b-b0adffa97502", "Відповідь 78", "047902f0-b550-4fa5-a260-feff9279373f" },
                    { "884b0b2a-fca6-4ec7-9eb4-f5c82ec17465", "Відповідь 64", "c43dbe6d-5571-448b-af78-58a68529c8c5" },
                    { "88b748f2-da29-4ecf-a9d7-58c5fcd7da48", "Відповідь 75", "0edc0aab-65bc-4998-95d7-859c5e751c98" },
                    { "8aafa6f4-c0b1-4ef3-8df4-3ff53f246e5d", "Відповідь 82", "d94492ca-4cea-411b-94ca-669b723bd426" },
                    { "94d5ebcf-c567-4f72-a199-95f12a4bb592", "Відповідь 32", "16c428ac-43d2-4396-9c2d-ee2e1e946073" },
                    { "96ece23f-7386-4481-bb84-1df72cb1c0bb", "Відповідь 4", "047902f0-b550-4fa5-a260-feff9279373f" },
                    { "98e3ecf8-ae15-428a-89ff-954b9e97168e", "Відповідь 17", "f846dae9-d25b-496b-85bf-7683b2e0e7cc" },
                    { "99cbd3ff-5f13-472e-968e-9860be79055e", "Відповідь 70", "caa62caf-160e-4ddc-8628-d144637c731e" },
                    { "9ac5e8c4-e71c-43a0-8195-23e03a721901", "Відповідь 5", "b7f124bc-d583-4320-bd8c-186d57973a84" },
                    { "9d20d6c7-9673-4205-9fa6-3044a2bb60c7", "Відповідь 15", "f846dae9-d25b-496b-85bf-7683b2e0e7cc" },
                    { "a09cc590-95e8-4261-94aa-bf5d9e62074b", "Відповідь 52", "cf9cbbdd-b0d4-4249-a600-8073451054e5" },
                    { "a196258d-afd3-458d-9692-a40d7ffe3491", "Відповідь 57", "047902f0-b550-4fa5-a260-feff9279373f" },
                    { "a21ffd18-e7b0-4e12-9810-d21e58995219", "Відповідь 1", "b781678a-de34-458b-a5d2-1e23d86a6484" },
                    { "a251f768-51be-4d0c-9498-5f4472199718", "Відповідь 78", "6afd4273-4755-4a70-8452-ed2e79652000" },
                    { "a6a99e86-479b-4cee-b7a5-1dde34f794cd", "Відповідь 50", "b781678a-de34-458b-a5d2-1e23d86a6484" },
                    { "a95cdeef-c11f-4f5d-a374-96db6c1492a2", "Відповідь 27", "0edc0aab-65bc-4998-95d7-859c5e751c98" },
                    { "b4daa7eb-dc8f-4a52-b369-207cf2050148", "Відповідь 25", "6afd4273-4755-4a70-8452-ed2e79652000" },
                    { "b9c73822-03f6-42c0-8f9c-205776ae892b", "Відповідь 32", "caa62caf-160e-4ddc-8628-d144637c731e" },
                    { "c3a7ad63-fa27-4210-b1ef-d1e487f2f642", "Відповідь 60", "0edc0aab-65bc-4998-95d7-859c5e751c98" },
                    { "c9e2b69f-a8aa-4aeb-a3bf-b612a9908db8", "Відповідь 49", "b7f124bc-d583-4320-bd8c-186d57973a84" },
                    { "ceb349a6-2382-4291-b7f4-5f4a4e62ae66", "Відповідь 54", "6afd4273-4755-4a70-8452-ed2e79652000" },
                    { "d02ae9fd-9f19-44e1-96a7-5a52056edd84", "Відповідь 69", "2bb4699a-d432-4e51-bdd8-24f0089d5d3d" },
                    { "d31cea73-ac82-4523-98c6-2b904cc70b40", "Відповідь 92", "f846dae9-d25b-496b-85bf-7683b2e0e7cc" },
                    { "d75e5721-c293-4e84-9db5-ed95de65cc5c", "Відповідь 58", "7b49c63d-379f-47bb-bb8a-8afa2586c8eb" },
                    { "d7b22c38-79a7-49c6-be50-7faeca776c3f", "Відповідь 29", "16c428ac-43d2-4396-9c2d-ee2e1e946073" },
                    { "e7003155-7495-4c38-8f1c-8f111b0fc979", "Відповідь 42", "b7f124bc-d583-4320-bd8c-186d57973a84" },
                    { "eb8d6dc5-58d5-4b15-ab71-f31bec15ba91", "Відповідь 78", "6afd4273-4755-4a70-8452-ed2e79652000" },
                    { "f467201b-655b-44bf-a2f1-930e02e8ec4c", "Відповідь 71", "cf9cbbdd-b0d4-4249-a600-8073451054e5" },
                    { "f4e4ae6b-b8d3-4d4e-add9-99214dddea14", "Відповідь 70", "cf9cbbdd-b0d4-4249-a600-8073451054e5" },
                    { "f72d5210-614b-4da9-8fca-83ea5d3126a9", "Відповідь 5", "2191f4e8-a7ba-45e3-8d41-da61ef25b873" },
                    { "f8e41b46-3c54-4ae0-a3ad-0f9b9ed7e73f", "Відповідь 62", "0edc0aab-65bc-4998-95d7-859c5e751c98" },
                    { "fa6616df-1ea8-4dc7-87a6-a97bcffd9608", "Відповідь 88", "d94492ca-4cea-411b-94ca-669b723bd426" },
                    { "fe03062b-4efc-437d-9aeb-e73cd0ab702f", "Відповідь 96", "2bb4699a-d432-4e51-bdd8-24f0089d5d3d" }
                });

            migrationBuilder.AddForeignKey(
                name: "fk_answers_questions_question_id",
                table: "answers",
                column: "question_id",
                principalTable: "questions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_questions_surveys_survey_id",
                table: "questions",
                column: "survey_id",
                principalTable: "surveys",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_respondent_survey_answers_respondent_surveys_respondent_sur",
                table: "respondent_survey_answers",
                column: "respondent_survey_id",
                principalTable: "respondent_surveys",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_respondent_surveys_surveys_survey_id",
                table: "respondent_surveys",
                column: "survey_id",
                principalTable: "surveys",
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
                name: "fk_questions_surveys_survey_id",
                table: "questions");

            migrationBuilder.DropForeignKey(
                name: "fk_respondent_survey_answers_respondent_surveys_respondent_sur",
                table: "respondent_survey_answers");

            migrationBuilder.DropForeignKey(
                name: "fk_respondent_surveys_surveys_survey_id",
                table: "respondent_surveys");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "0a07d221-6866-4674-abc3-f3390aa7345a");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "0b0cffbd-4f4a-432e-a66f-7d1f140738b6");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "0b264823-305f-471d-9d7e-92e3fc9b937d");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "10e3f030-53e2-42d3-8fce-d943d1c3a276");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "1a3d4422-13b4-41c1-8d52-4f70d00f2648");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "1d93ade1-13b1-40c8-9731-542307d4ef56");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "1e93ad94-c71e-4f4e-b352-efccce5b2467");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "1fae2821-d7ec-4376-be5f-52afaa42d23b");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "23e6e7b3-7d88-4fc9-88e6-d013373bb8ec");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "24d06306-e402-4bd7-a853-155bbcf2992b");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "3325ea8e-409c-4f73-a051-56dd5f226d66");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "34b9a264-42d8-42b1-9a95-f19daa8ff998");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "355bac16-3086-4403-955c-6910e31de947");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "376555f6-395e-4b8a-a6b2-2e22ced7ac2a");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "39aca928-10e4-4ec0-b756-54f036e20a95");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "40d66e60-1664-43fa-a4c3-ce3deb7af848");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "4329f923-e9da-4ad5-9b86-a7aaa7a66ee9");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "4df47b6d-cab5-4ae4-bd40-7dccd18efda2");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "52635b69-8da4-4d44-8d13-46613c43bb43");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "5556316a-b00f-4843-84a3-4060a4f33e7f");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "58ba565e-ea3a-459d-8f75-0e9e1ae39e6d");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "5c0349dd-7445-4162-839b-62dcff8a3567");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "5ff93ade-dfb5-437a-8739-d6e778b73fc7");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "6529135e-1ff3-44f1-aaff-6f4111465faa");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "663bde69-3663-448b-a357-f11ed086266a");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "686e8897-ea89-4b5f-9317-a6cf508f01d9");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "6a7469cb-79c5-42d4-af7e-eac1528c5b58");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "71bfa9ac-d166-49a2-b169-392ce8a7c0f2");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "7385d718-4619-44a6-a458-5a792ff084df");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "7c725aeb-38b1-4ae9-8bbe-972e3d061cee");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "81ba4a7f-a913-4f34-9e1b-b95056a7e4a2");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "862378db-6659-4641-a13b-b0adffa97502");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "884b0b2a-fca6-4ec7-9eb4-f5c82ec17465");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "88b748f2-da29-4ecf-a9d7-58c5fcd7da48");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "8aafa6f4-c0b1-4ef3-8df4-3ff53f246e5d");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "94d5ebcf-c567-4f72-a199-95f12a4bb592");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "96ece23f-7386-4481-bb84-1df72cb1c0bb");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "98e3ecf8-ae15-428a-89ff-954b9e97168e");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "99cbd3ff-5f13-472e-968e-9860be79055e");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "9ac5e8c4-e71c-43a0-8195-23e03a721901");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "9d20d6c7-9673-4205-9fa6-3044a2bb60c7");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "a09cc590-95e8-4261-94aa-bf5d9e62074b");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "a196258d-afd3-458d-9692-a40d7ffe3491");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "a21ffd18-e7b0-4e12-9810-d21e58995219");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "a251f768-51be-4d0c-9498-5f4472199718");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "a6a99e86-479b-4cee-b7a5-1dde34f794cd");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "a95cdeef-c11f-4f5d-a374-96db6c1492a2");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "b4daa7eb-dc8f-4a52-b369-207cf2050148");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "b9c73822-03f6-42c0-8f9c-205776ae892b");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "c3a7ad63-fa27-4210-b1ef-d1e487f2f642");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "c9e2b69f-a8aa-4aeb-a3bf-b612a9908db8");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "ceb349a6-2382-4291-b7f4-5f4a4e62ae66");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "d02ae9fd-9f19-44e1-96a7-5a52056edd84");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "d31cea73-ac82-4523-98c6-2b904cc70b40");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "d75e5721-c293-4e84-9db5-ed95de65cc5c");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "d7b22c38-79a7-49c6-be50-7faeca776c3f");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "e7003155-7495-4c38-8f1c-8f111b0fc979");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "eb8d6dc5-58d5-4b15-ab71-f31bec15ba91");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "f467201b-655b-44bf-a2f1-930e02e8ec4c");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "f4e4ae6b-b8d3-4d4e-add9-99214dddea14");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "f72d5210-614b-4da9-8fca-83ea5d3126a9");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "f8e41b46-3c54-4ae0-a3ad-0f9b9ed7e73f");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "fa6616df-1ea8-4dc7-87a6-a97bcffd9608");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "fe03062b-4efc-437d-9aeb-e73cd0ab702f");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "047902f0-b550-4fa5-a260-feff9279373f");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "0edc0aab-65bc-4998-95d7-859c5e751c98");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "16c428ac-43d2-4396-9c2d-ee2e1e946073");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "2191f4e8-a7ba-45e3-8d41-da61ef25b873");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "2bb4699a-d432-4e51-bdd8-24f0089d5d3d");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "6afd4273-4755-4a70-8452-ed2e79652000");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "7b49c63d-379f-47bb-bb8a-8afa2586c8eb");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "b781678a-de34-458b-a5d2-1e23d86a6484");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "b7f124bc-d583-4320-bd8c-186d57973a84");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "c43dbe6d-5571-448b-af78-58a68529c8c5");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "c9baf7e5-ebb9-4498-adc7-6e87990d2636");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "caa62caf-160e-4ddc-8628-d144637c731e");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "cf9cbbdd-b0d4-4249-a600-8073451054e5");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "d94492ca-4cea-411b-94ca-669b723bd426");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "f846dae9-d25b-496b-85bf-7683b2e0e7cc");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "fae45801-2c7a-47ae-88f0-9998116409cb");

            migrationBuilder.DeleteData(
                table: "surveys",
                keyColumn: "id",
                keyValue: "2a5c430e-6c91-41a8-840c-745b14c3e430");

            migrationBuilder.DeleteData(
                table: "surveys",
                keyColumn: "id",
                keyValue: "66908dd3-7431-4742-b97b-35419aeaf7ad");

            migrationBuilder.DeleteData(
                table: "surveys",
                keyColumn: "id",
                keyValue: "af8ffc99-ab31-4d32-8252-1c27b9756858");

            migrationBuilder.DeleteData(
                table: "surveys",
                keyColumn: "id",
                keyValue: "c6d37fbc-d07b-40c6-9a84-6214326d753c");

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "id",
                keyValue: "729e7118-9994-4318-9ca0-84a3d3ff3a67");

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "id",
                keyValue: "9f18a11d-d392-48e3-87eb-916536aa49d4");

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "id",
                keyValue: "d56e3b51-f341-49f6-b803-0fb8494e01d0");

            migrationBuilder.AlterColumn<string>(
                name: "survey_id",
                table: "respondent_surveys",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "respondent_survey_id",
                table: "respondent_survey_answers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "survey_id",
                table: "questions",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "question_id",
                table: "answers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddForeignKey(
                name: "fk_answers_questions_question_id",
                table: "answers",
                column: "question_id",
                principalTable: "questions",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_questions_surveys_survey_id",
                table: "questions",
                column: "survey_id",
                principalTable: "surveys",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_respondent_survey_answers_respondent_surveys_respondent_sur",
                table: "respondent_survey_answers",
                column: "respondent_survey_id",
                principalTable: "respondent_surveys",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_respondent_surveys_surveys_survey_id",
                table: "respondent_surveys",
                column: "survey_id",
                principalTable: "surveys",
                principalColumn: "id");
        }
    }
}
