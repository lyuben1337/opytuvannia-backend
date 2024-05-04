using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace opytuvannia_backend.Migrations
{
    /// <inheritdoc />
    public partial class AddedRespondentRewordManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_respondent_reward_respondents_respondent_id",
                table: "respondent_reward");

            migrationBuilder.DropPrimaryKey(
                name: "pk_respondent_reward",
                table: "respondent_reward");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "02d1740d-c0f3-4a38-8338-099b021e25b1");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "02d3824d-1fdc-429f-86d8-b6e8834618b2");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "035b0589-bb77-4677-80f2-4e0d0c07dd9f");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "035c7b92-52f7-4956-ae6e-df0ddb90234d");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "041d77e3-11ca-4835-a373-b3f8d6e73ae5");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "0eee8e4b-de17-4294-b0a2-ce763c90b710");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "164034e6-5e6a-4c26-97c2-a7a492cfc342");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "16dbc31f-bad6-4766-84d2-6cad3a765fb8");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "1a693c72-99c1-4da8-b866-47ad7bf3389a");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "1c7a3485-b003-43dc-a7ca-b10731670108");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "1f0d7cb1-c83a-4381-88c8-8448ee7b0ad5");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "1f9d897c-9167-483c-b12b-d932f44d988b");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "247861f5-b31c-45be-9099-fd40793f60a9");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "2956b1cf-6562-470a-9cb2-5d5af59aa3ac");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "2e0cc471-f6e5-4354-bb03-f3e607bfaa8f");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "31662ed9-4990-4930-9401-eb50813f6d62");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "3213a5cd-fc99-4b9d-9b28-1e190e13a88f");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "36a4531b-e7e3-4efd-8b8d-94ea6a95a242");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "3a3c51c6-3d34-4902-bef6-fc2f0c7031ae");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "3c1bcff9-bede-4bc8-940f-863e7f735634");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "3e9e54d6-074d-48f7-bfcf-472f5b2089c2");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "3fba1b3f-8222-4d9d-947f-1da856ce948c");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "4e1c1d98-fb05-41f9-9e70-cff217e1c787");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "51ec36b7-1259-45b1-afc4-5b4b94db281d");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "5a972830-996b-4d0c-a696-e529db2d1264");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "5b2d53b9-0215-4b80-9b41-4e11b9ed492b");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "60e83f56-8c87-4947-9dfc-bfddd3ee6b87");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "6ab56bac-2016-4752-8ece-f5e66301defe");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "7507f6d8-8395-4905-9426-853d4b506c53");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "77fd9ab9-6d54-4eb1-8970-8a1b8e89c60b");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "7ba6bdf7-59b2-4ebf-8818-429cb73b1661");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "7e878d7b-8d17-4757-a5de-7446e0001743");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "8368d15c-a9aa-4a54-99c7-91e1a0be6b72");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "838689c3-d16d-4d3f-8dae-5208145b21a7");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "83f26dff-93c1-43e9-a758-0fdef393d5d5");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "891f8a89-a793-41e3-8d75-9f4deea608d6");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "8ac2ab72-2fa8-42ec-a8f6-902e4bacb882");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "8cc2353b-0c64-4a11-a315-dcc8bc1c487b");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "9f50ab0e-dd5c-4155-ab5d-0b4aba19b911");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "a1a1dd31-2700-426b-817b-bdc42dd29b53");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "a4ae58c7-8b8c-4fd5-95d8-8e1525b94fc2");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "a8096540-834c-4f95-9317-fa5773d3676b");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "a8e6c2b9-658f-4058-8be0-775d86d179e1");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "aa96bda8-a222-4223-b724-b906e96a68bc");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "ad851c3c-4317-4a5c-94c5-5fa521d405d8");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "adab1c34-8076-4e46-b088-3998d44b3f34");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "b47fd5b3-3717-4c45-801b-5843699066d5");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "b9b9cdae-2131-497d-b678-4786b5ad00fb");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "bb06a73a-0cce-49c3-a0d3-503e71ab6855");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "c2e77091-974a-4019-8424-39f881314f70");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "d66db0c9-2e9a-4ff0-863c-64b44f52c990");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "d7fe748b-51a3-41b8-be5d-bb7e94767795");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "df821a9e-97fc-4075-a42a-5c03f4587152");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "e2f87636-f079-436f-ae6d-0f5a92539dd7");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "e433759e-1a15-4f13-a476-549581b071de");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "e4489d91-6fa4-43a2-8a84-fffa3199e8fd");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "e7c4c6b2-2313-4f24-9c86-2c25e3e22557");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "e8d12e13-61d1-4c28-be6b-20a5b452631f");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "ed4e2d0e-8dca-49fe-84f3-3b2244fe67c7");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "f0e5d721-eced-408a-92cf-3d371daf5412");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "f8c0c73a-9fb3-4b3a-a6ab-10e445820812");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "f9dd026a-c159-4040-8c3b-4995e9ada2af");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "fb381457-622e-4ebe-9d09-26859ae0a806");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "ff7cc8eb-0122-4967-9fd2-402b56db97a9");

            migrationBuilder.DeleteData(
                table: "rewards",
                keyColumn: "id",
                keyValue: "9d787398-4942-42e2-9ed1-c56f96326644");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "08b47494-defb-4bf6-b5f7-d861d0f01e59");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "15e8db4e-bb53-4164-8ac9-0e1e995d2e1f");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "2d6da8e2-dc0b-47e7-962b-b8cd3997eba5");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "2fec5013-2680-43a6-8621-40d14ec904c0");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "482e42f4-f116-4b47-b0ae-10b70354755d");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "488e1580-2be8-4224-a479-035586148414");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "4c6005ec-2113-45f8-a244-44b46fc41e71");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "5aa48f79-3caa-4536-ab92-6675a5ce19cc");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "6d3d0979-35c7-47e7-ad80-56b5fe36307b");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "81638814-b787-486a-a9c9-610b8a16d3e1");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "9dca22e2-4bd9-4a82-882a-f19835c95118");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "ab44fa3d-7ab9-41e2-9592-9ea7b99bf39b");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "c085cd1d-4894-43f8-b383-d17371636f1c");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "c82ae074-05e3-4b6f-8789-e951720658a0");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "cb1f165b-2950-481b-91a2-89174acad2b8");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "d504962b-d5ef-4d58-af58-606a2c852610");

            migrationBuilder.DeleteData(
                table: "surveys",
                keyColumn: "id",
                keyValue: "36d380a6-7007-4928-9e00-ca3c9a1acf14");

            migrationBuilder.DeleteData(
                table: "surveys",
                keyColumn: "id",
                keyValue: "3828d7fc-7b50-4da6-8884-599db176a644");

            migrationBuilder.DeleteData(
                table: "surveys",
                keyColumn: "id",
                keyValue: "46cdf134-5d3b-4dfb-9dfb-039681eb932f");

            migrationBuilder.DeleteData(
                table: "surveys",
                keyColumn: "id",
                keyValue: "51fb15c3-a702-41a6-8653-40b1cbd5e628");

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "id",
                keyValue: "5046df65-b65e-4a6b-bb8a-e05c1b21f4e3");

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "id",
                keyValue: "57d591d7-b380-4763-8615-58231b984942");

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "id",
                keyValue: "75fcdb74-bee8-4441-bab0-7225a7553ea2");

            migrationBuilder.DeleteData(
                table: "rewards",
                keyColumn: "id",
                keyValue: "3e4c4aeb-80c4-4120-8885-b6e566ee368f");

            migrationBuilder.DeleteData(
                table: "rewards",
                keyColumn: "id",
                keyValue: "3ff1ce43-d650-4ea8-a409-cfe4c6170988");

            migrationBuilder.DeleteData(
                table: "rewards",
                keyColumn: "id",
                keyValue: "7b128dcf-8520-4c18-ac6c-75e6bd1cb349");

            migrationBuilder.RenameTable(
                name: "respondent_reward",
                newName: "respondent_rewards");

            migrationBuilder.RenameIndex(
                name: "ix_respondent_reward_respondent_id",
                table: "respondent_rewards",
                newName: "ix_respondent_rewards_respondent_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_respondent_rewards",
                table: "respondent_rewards",
                column: "id");

            migrationBuilder.InsertData(
                table: "companies",
                columns: new[] { "id", "logo_src", "name" },
                values: new object[,]
                {
                    { "0929179e-ae8c-4bfc-826a-57c69b0de18c", "https://silpo.ua/images/silpo_fb_share.png", "Сільпо" },
                    { "8f19e9a6-5538-403a-bbfa-9bf4d3d67934", "https://cdn.metro-online.com/-/media/Project/MCW/RU_Metro/2021/join-us/Metro.png?rev=fe69769d14aa4105bc7e5731e32ebfc7&w=339&hash=783A0BB0789E586BB438C44B0778558A", "Metro" },
                    { "e1a9cebb-661b-475a-9ae3-323883e497eb", "https://allretail.ua/static/files/originals/2/85/30b01f786bd9a28d98e745247184f852.svg", "АТБ" }
                });

            migrationBuilder.InsertData(
                table: "rewards",
                columns: new[] { "id", "content" },
                values: new object[,]
                {
                    { "053330d5-6641-4006-acf8-7d9b11fa1fa7", "Промокод -50% на чернігівське титан zxcqw-e13371000-7wwww" },
                    { "2e284ad6-3824-42b7-904b-37a1a5db9991", "Безкоштовна доставка при наступному замовленні" },
                    { "3fbc03c5-da3d-4326-89c9-4a21f601c19d", "Знижка 10% на наступну покупку" },
                    { "5558e8e0-7736-4a40-9153-b6b6ba2c6679", "+100 грн" }
                });

            migrationBuilder.InsertData(
                table: "surveys",
                columns: new[] { "id", "company_id", "description", "reward_id", "title" },
                values: new object[,]
                {
                    { "2091f48c-a6a6-4c03-b1cd-75d4488c06aa", "8f19e9a6-5538-403a-bbfa-9bf4d3d67934", "Допоможіть нам визначити найпопулярніший продукт в Metro", "5558e8e0-7736-4a40-9153-b6b6ba2c6679", "Найкращий продукт" },
                    { "273f4d05-315b-48e5-8938-4746bab72b5c", "e1a9cebb-661b-475a-9ae3-323883e497eb", "Оцініть якість обслуговування в наших магазинах", "3fbc03c5-da3d-4326-89c9-4a21f601c19d", "Якість обслуговування" },
                    { "53ddc52b-0cfe-4de4-b353-30ff6f0d8133", "0929179e-ae8c-4bfc-826a-57c69b0de18c", "Опитування про ваші уподобання щодо пива", "053330d5-6641-4006-acf8-7d9b11fa1fa7", "Споживання пива" },
                    { "b66d55d6-61d9-403b-b22f-0cab26599468", "e1a9cebb-661b-475a-9ae3-323883e497eb", "Щоб покращити обслуговування, просимо вас взяти участь в нашому опитуванні", "3fbc03c5-da3d-4326-89c9-4a21f601c19d", "Ваші покупки в АТБ" }
                });

            migrationBuilder.InsertData(
                table: "questions",
                columns: new[] { "id", "survey_id", "title" },
                values: new object[,]
                {
                    { "2e1dd1de-b3b4-4c5b-8c08-d998e0bd742e", "2091f48c-a6a6-4c03-b1cd-75d4488c06aa", "Чи задоволені ви асортиментом товарів у наших магазинах?" },
                    { "3037d92a-b64c-4727-bacb-aea136abf8e5", "53ddc52b-0cfe-4de4-b353-30ff6f0d8133", "Чи спробували ви нові сорти пива в нашому магазині?" },
                    { "3f867ec4-bf5a-4f83-b330-63fc1af3968a", "273f4d05-315b-48e5-8938-4746bab72b5c", "Як ви оцінюєте чистоту наших магазинів?" },
                    { "44b50da0-1a6d-4df3-8538-0185c2e9e5b8", "53ddc52b-0cfe-4de4-b353-30ff6f0d8133", "Яке пиво ви купуєте найчастіше?" },
                    { "622e953a-1706-44cf-b512-00ca87c7054f", "2091f48c-a6a6-4c03-b1cd-75d4488c06aa", "Який продукт ви купуєте найчастіше в Metro?" },
                    { "8195b8f6-1ce1-4d5e-990c-d638475906ca", "2091f48c-a6a6-4c03-b1cd-75d4488c06aa", "Як часто ви відвідуєте наші магазини?" },
                    { "98363f4e-59fb-4929-b33f-a8b41413a59c", "2091f48c-a6a6-4c03-b1cd-75d4488c06aa", "Які характеристики товарів важливі для вас при покупці?" },
                    { "99e6660f-7cbe-408e-816e-4884e36710a3", "b66d55d6-61d9-403b-b22f-0cab26599468", "Які товари ви найчастіше купуєте в наших магазинах?" },
                    { "a1f50cf9-1d0e-4a8b-aed8-f786fa183871", "53ddc52b-0cfe-4de4-b353-30ff6f0d8133", "Як часто ви купуєте пиво в наших магазинах?" },
                    { "a9a93533-04fe-4393-ab00-b2b38a6fd4c7", "273f4d05-315b-48e5-8938-4746bab72b5c", "Чи вважаєте ви, що у нас завжди є необхідні товари?" },
                    { "acf21d61-127e-43c9-a826-42b3a1f9c27a", "b66d55d6-61d9-403b-b22f-0cab26599468", "Чи вважаєте ви наші ціни конкурентоспроможними?" },
                    { "b304ceea-354a-48a5-9fd4-cfbaba3ed807", "b66d55d6-61d9-403b-b22f-0cab26599468", "Чи задоволені ви якістю обслуговування у наших магазинах?" },
                    { "ba93de1a-3b88-412f-bf99-25f0b05e8fba", "53ddc52b-0cfe-4de4-b353-30ff6f0d8133", "Які характеристики пива важливі для вас?" },
                    { "bf909ffa-8185-4667-8305-106bf0da54a7", "b66d55d6-61d9-403b-b22f-0cab26599468", "Як часто ви здійснюєте покупки в АТБ?" },
                    { "f289bd58-6f6d-4e14-bf6a-098f53828b06", "273f4d05-315b-48e5-8938-4746bab72b5c", "Чи допомагає вам персонал з пошуком товарів?" },
                    { "f510e273-0b21-49a2-913d-f183cabd1ba2", "273f4d05-315b-48e5-8938-4746bab72b5c", "Чи радите ви своїм знайомим відвідувати магазини АТБ?" }
                });

            migrationBuilder.InsertData(
                table: "answers",
                columns: new[] { "id", "content", "question_id" },
                values: new object[,]
                {
                    { "033e9d93-6036-48e7-bbac-765a12439518", "Відповідь 9", "44b50da0-1a6d-4df3-8538-0185c2e9e5b8" },
                    { "076e5ae7-314f-4fd4-8ab9-e015f6a4f665", "Відповідь 2", "f289bd58-6f6d-4e14-bf6a-098f53828b06" },
                    { "0a0e17a6-4605-404b-9b79-6dd992959624", "Відповідь 39", "44b50da0-1a6d-4df3-8538-0185c2e9e5b8" },
                    { "0d21bb3b-a710-4227-afe8-ac7e9ac52b3c", "Відповідь 2", "acf21d61-127e-43c9-a826-42b3a1f9c27a" },
                    { "1718fb86-f26a-4744-8b64-099db417e536", "Відповідь 3", "acf21d61-127e-43c9-a826-42b3a1f9c27a" },
                    { "21c2459a-599b-40b3-8c22-4a58a1be6b5f", "Відповідь 41", "bf909ffa-8185-4667-8305-106bf0da54a7" },
                    { "238a99d6-fb25-45f3-a001-c740bfbb0e88", "Відповідь 16", "8195b8f6-1ce1-4d5e-990c-d638475906ca" },
                    { "25c86609-c5b1-4a05-a27b-bbffe3a6580b", "Відповідь 20", "f510e273-0b21-49a2-913d-f183cabd1ba2" },
                    { "2605f03a-da24-4178-8f8d-bc229ad1a9d9", "Відповідь 54", "2e1dd1de-b3b4-4c5b-8c08-d998e0bd742e" },
                    { "293f2544-0b3b-45a6-86c8-4972a6e888e4", "Відповідь 13", "a9a93533-04fe-4393-ab00-b2b38a6fd4c7" },
                    { "2f1c1f9c-f650-4fab-b732-8818045baadc", "Відповідь 97", "98363f4e-59fb-4929-b33f-a8b41413a59c" },
                    { "322e5ea3-7921-4993-8b1d-0001907e4081", "Відповідь 24", "a1f50cf9-1d0e-4a8b-aed8-f786fa183871" },
                    { "356ce86a-3daa-4dda-a922-e878321f4a97", "Відповідь 80", "3037d92a-b64c-4727-bacb-aea136abf8e5" },
                    { "37e7f517-2f71-46ca-ae7f-d303cff65ce4", "Відповідь 7", "b304ceea-354a-48a5-9fd4-cfbaba3ed807" },
                    { "393589ff-ff99-4e6f-9c21-5fea3b5e77a5", "Відповідь 4", "acf21d61-127e-43c9-a826-42b3a1f9c27a" },
                    { "48b0099f-52aa-40b6-a760-e7bda01c723a", "Відповідь 62", "f510e273-0b21-49a2-913d-f183cabd1ba2" },
                    { "4a2a4eb9-df14-4796-a2e0-73eb49e9f516", "Відповідь 53", "622e953a-1706-44cf-b512-00ca87c7054f" },
                    { "4b8f3012-e7ca-4ab4-a220-71e0832d5e0b", "Відповідь 33", "3037d92a-b64c-4727-bacb-aea136abf8e5" },
                    { "4eacdec9-5069-4327-b0df-10ab492fcf04", "Відповідь 80", "ba93de1a-3b88-412f-bf99-25f0b05e8fba" },
                    { "52395681-7ea9-4cc6-b78f-bd180bde6fb8", "Відповідь 98", "99e6660f-7cbe-408e-816e-4884e36710a3" },
                    { "52bf526e-a8db-4018-ab42-0f6b1434ebff", "Відповідь 27", "3f867ec4-bf5a-4f83-b330-63fc1af3968a" },
                    { "5900fb6a-776f-40fa-97bb-c0dcbffe0ec4", "Відповідь 75", "b304ceea-354a-48a5-9fd4-cfbaba3ed807" },
                    { "5b949545-9da9-475d-b545-18889e1dd1b1", "Відповідь 64", "99e6660f-7cbe-408e-816e-4884e36710a3" },
                    { "5e866ba8-a5a3-4136-b3cc-3e32986ae40e", "Відповідь 10", "a1f50cf9-1d0e-4a8b-aed8-f786fa183871" },
                    { "631b5ac6-15d6-4d00-9a17-b6fc7e551c1d", "Відповідь 48", "f289bd58-6f6d-4e14-bf6a-098f53828b06" },
                    { "67921382-790e-49ba-875e-476e9f6e11b0", "Відповідь 62", "ba93de1a-3b88-412f-bf99-25f0b05e8fba" },
                    { "7a4271d1-db95-40f8-b2b1-d556b3268bbd", "Відповідь 84", "f289bd58-6f6d-4e14-bf6a-098f53828b06" },
                    { "7d04cca2-4849-4994-bd7d-d2a4fa0f5a5d", "Відповідь 9", "f289bd58-6f6d-4e14-bf6a-098f53828b06" },
                    { "7fd0e495-9998-4079-846e-0f0dd2a5c4f7", "Відповідь 17", "99e6660f-7cbe-408e-816e-4884e36710a3" },
                    { "8066edc3-20f3-42c7-9542-3c91f0d79e1d", "Відповідь 95", "44b50da0-1a6d-4df3-8538-0185c2e9e5b8" },
                    { "83450f9b-46c7-48f6-84d0-b4fe81393ae4", "Відповідь 87", "98363f4e-59fb-4929-b33f-a8b41413a59c" },
                    { "83778108-4034-4406-8bff-4123724316b1", "Відповідь 91", "8195b8f6-1ce1-4d5e-990c-d638475906ca" },
                    { "83a27d2f-6e1e-4d71-8dc0-fb1fab69770d", "Відповідь 97", "f510e273-0b21-49a2-913d-f183cabd1ba2" },
                    { "86c0a865-e1f7-47ed-a437-32855dcaaa1c", "Відповідь 40", "622e953a-1706-44cf-b512-00ca87c7054f" },
                    { "87fa5bf0-38aa-45e3-a49e-e88df5521cbb", "Відповідь 31", "99e6660f-7cbe-408e-816e-4884e36710a3" },
                    { "8c69081d-1374-4e07-b546-f86237671124", "Відповідь 77", "8195b8f6-1ce1-4d5e-990c-d638475906ca" },
                    { "90253d61-c59b-434b-943c-382f0439694d", "Відповідь 65", "3f867ec4-bf5a-4f83-b330-63fc1af3968a" },
                    { "9461a664-3b72-482a-8f99-2918724b04d3", "Відповідь 67", "2e1dd1de-b3b4-4c5b-8c08-d998e0bd742e" },
                    { "9b200205-561f-47a1-89f6-95b905633a32", "Відповідь 44", "a1f50cf9-1d0e-4a8b-aed8-f786fa183871" },
                    { "9c9a6674-6d79-4226-923e-fb31094cada9", "Відповідь 48", "98363f4e-59fb-4929-b33f-a8b41413a59c" },
                    { "9f84aa62-2fea-4341-9fa1-5fcf6873c44a", "Відповідь 31", "3f867ec4-bf5a-4f83-b330-63fc1af3968a" },
                    { "a0345972-9c4a-4712-8584-69a1ac9da4cb", "Відповідь 26", "acf21d61-127e-43c9-a826-42b3a1f9c27a" },
                    { "a2c83c72-8124-46ed-a6de-e7c3727e03fb", "Відповідь 80", "a9a93533-04fe-4393-ab00-b2b38a6fd4c7" },
                    { "a4716804-23f2-4ce6-8b67-b67586c43fef", "Відповідь 96", "2e1dd1de-b3b4-4c5b-8c08-d998e0bd742e" },
                    { "a4a1a5be-155a-4998-a9f3-aebbecf0c4f8", "Відповідь 31", "b304ceea-354a-48a5-9fd4-cfbaba3ed807" },
                    { "a7ca61e3-8392-4fc1-bc32-0c2cc85093a9", "Відповідь 42", "a1f50cf9-1d0e-4a8b-aed8-f786fa183871" },
                    { "afd1399c-63d2-4b1f-a9a8-321addedc4e0", "Відповідь 95", "ba93de1a-3b88-412f-bf99-25f0b05e8fba" },
                    { "b0c5dff5-c38e-48c7-96a3-88caecb6dd7d", "Відповідь 68", "b304ceea-354a-48a5-9fd4-cfbaba3ed807" },
                    { "b3bedc7b-da32-4b48-b415-7dd56810f2a3", "Відповідь 46", "a9a93533-04fe-4393-ab00-b2b38a6fd4c7" },
                    { "bb3bf8c1-fc6d-4296-8af7-03c14d36bc72", "Відповідь 80", "622e953a-1706-44cf-b512-00ca87c7054f" },
                    { "c4f3d7a1-8ef4-4107-ad88-3c5cad8e5bc3", "Відповідь 8", "bf909ffa-8185-4667-8305-106bf0da54a7" },
                    { "c5da8717-841a-4005-b64b-39dd5a6e7b2b", "Відповідь 63", "a9a93533-04fe-4393-ab00-b2b38a6fd4c7" },
                    { "c8e00b36-4c97-447c-b0e0-6f07e9ba2479", "Відповідь 32", "98363f4e-59fb-4929-b33f-a8b41413a59c" },
                    { "ca56748d-063f-46c8-bc5a-b91172075ecf", "Відповідь 90", "3037d92a-b64c-4727-bacb-aea136abf8e5" },
                    { "d4a6abb3-c453-450d-bfad-00dcbbdd67a8", "Відповідь 36", "44b50da0-1a6d-4df3-8538-0185c2e9e5b8" },
                    { "da3aa296-6bb4-4b73-b5a2-31a52678d398", "Відповідь 25", "f510e273-0b21-49a2-913d-f183cabd1ba2" },
                    { "e0f0a649-2b53-43f8-8f67-05e8fbe3d86a", "Відповідь 15", "ba93de1a-3b88-412f-bf99-25f0b05e8fba" },
                    { "e612915f-8375-4810-988f-5f0e10a901af", "Відповідь 16", "622e953a-1706-44cf-b512-00ca87c7054f" },
                    { "eab147af-0956-4284-97be-221b23a87da2", "Відповідь 96", "2e1dd1de-b3b4-4c5b-8c08-d998e0bd742e" },
                    { "f1bc7a93-831d-4cce-b8ed-a20d04c38714", "Відповідь 62", "8195b8f6-1ce1-4d5e-990c-d638475906ca" },
                    { "f2cd314c-d253-4ae3-9864-cb672a39fa98", "Відповідь 57", "bf909ffa-8185-4667-8305-106bf0da54a7" },
                    { "f36a0a82-004c-4603-a78a-39f6a4ae49f0", "Відповідь 47", "3037d92a-b64c-4727-bacb-aea136abf8e5" },
                    { "fa948e5e-5240-4509-a571-b7a3dc49482a", "Відповідь 98", "3f867ec4-bf5a-4f83-b330-63fc1af3968a" },
                    { "ff3ac852-71b1-4e98-836a-257795dec411", "Відповідь 60", "bf909ffa-8185-4667-8305-106bf0da54a7" }
                });

            migrationBuilder.AddForeignKey(
                name: "fk_respondent_rewards_respondents_respondent_id",
                table: "respondent_rewards",
                column: "respondent_id",
                principalTable: "respondents",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_respondent_rewards_respondents_respondent_id",
                table: "respondent_rewards");

            migrationBuilder.DropPrimaryKey(
                name: "pk_respondent_rewards",
                table: "respondent_rewards");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "033e9d93-6036-48e7-bbac-765a12439518");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "076e5ae7-314f-4fd4-8ab9-e015f6a4f665");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "0a0e17a6-4605-404b-9b79-6dd992959624");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "0d21bb3b-a710-4227-afe8-ac7e9ac52b3c");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "1718fb86-f26a-4744-8b64-099db417e536");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "21c2459a-599b-40b3-8c22-4a58a1be6b5f");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "238a99d6-fb25-45f3-a001-c740bfbb0e88");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "25c86609-c5b1-4a05-a27b-bbffe3a6580b");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "2605f03a-da24-4178-8f8d-bc229ad1a9d9");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "293f2544-0b3b-45a6-86c8-4972a6e888e4");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "2f1c1f9c-f650-4fab-b732-8818045baadc");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "322e5ea3-7921-4993-8b1d-0001907e4081");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "356ce86a-3daa-4dda-a922-e878321f4a97");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "37e7f517-2f71-46ca-ae7f-d303cff65ce4");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "393589ff-ff99-4e6f-9c21-5fea3b5e77a5");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "48b0099f-52aa-40b6-a760-e7bda01c723a");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "4a2a4eb9-df14-4796-a2e0-73eb49e9f516");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "4b8f3012-e7ca-4ab4-a220-71e0832d5e0b");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "4eacdec9-5069-4327-b0df-10ab492fcf04");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "52395681-7ea9-4cc6-b78f-bd180bde6fb8");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "52bf526e-a8db-4018-ab42-0f6b1434ebff");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "5900fb6a-776f-40fa-97bb-c0dcbffe0ec4");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "5b949545-9da9-475d-b545-18889e1dd1b1");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "5e866ba8-a5a3-4136-b3cc-3e32986ae40e");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "631b5ac6-15d6-4d00-9a17-b6fc7e551c1d");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "67921382-790e-49ba-875e-476e9f6e11b0");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "7a4271d1-db95-40f8-b2b1-d556b3268bbd");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "7d04cca2-4849-4994-bd7d-d2a4fa0f5a5d");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "7fd0e495-9998-4079-846e-0f0dd2a5c4f7");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "8066edc3-20f3-42c7-9542-3c91f0d79e1d");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "83450f9b-46c7-48f6-84d0-b4fe81393ae4");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "83778108-4034-4406-8bff-4123724316b1");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "83a27d2f-6e1e-4d71-8dc0-fb1fab69770d");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "86c0a865-e1f7-47ed-a437-32855dcaaa1c");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "87fa5bf0-38aa-45e3-a49e-e88df5521cbb");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "8c69081d-1374-4e07-b546-f86237671124");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "90253d61-c59b-434b-943c-382f0439694d");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "9461a664-3b72-482a-8f99-2918724b04d3");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "9b200205-561f-47a1-89f6-95b905633a32");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "9c9a6674-6d79-4226-923e-fb31094cada9");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "9f84aa62-2fea-4341-9fa1-5fcf6873c44a");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "a0345972-9c4a-4712-8584-69a1ac9da4cb");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "a2c83c72-8124-46ed-a6de-e7c3727e03fb");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "a4716804-23f2-4ce6-8b67-b67586c43fef");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "a4a1a5be-155a-4998-a9f3-aebbecf0c4f8");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "a7ca61e3-8392-4fc1-bc32-0c2cc85093a9");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "afd1399c-63d2-4b1f-a9a8-321addedc4e0");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "b0c5dff5-c38e-48c7-96a3-88caecb6dd7d");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "b3bedc7b-da32-4b48-b415-7dd56810f2a3");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "bb3bf8c1-fc6d-4296-8af7-03c14d36bc72");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "c4f3d7a1-8ef4-4107-ad88-3c5cad8e5bc3");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "c5da8717-841a-4005-b64b-39dd5a6e7b2b");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "c8e00b36-4c97-447c-b0e0-6f07e9ba2479");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "ca56748d-063f-46c8-bc5a-b91172075ecf");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "d4a6abb3-c453-450d-bfad-00dcbbdd67a8");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "da3aa296-6bb4-4b73-b5a2-31a52678d398");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "e0f0a649-2b53-43f8-8f67-05e8fbe3d86a");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "e612915f-8375-4810-988f-5f0e10a901af");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "eab147af-0956-4284-97be-221b23a87da2");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "f1bc7a93-831d-4cce-b8ed-a20d04c38714");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "f2cd314c-d253-4ae3-9864-cb672a39fa98");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "f36a0a82-004c-4603-a78a-39f6a4ae49f0");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "fa948e5e-5240-4509-a571-b7a3dc49482a");

            migrationBuilder.DeleteData(
                table: "answers",
                keyColumn: "id",
                keyValue: "ff3ac852-71b1-4e98-836a-257795dec411");

            migrationBuilder.DeleteData(
                table: "rewards",
                keyColumn: "id",
                keyValue: "2e284ad6-3824-42b7-904b-37a1a5db9991");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "2e1dd1de-b3b4-4c5b-8c08-d998e0bd742e");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "3037d92a-b64c-4727-bacb-aea136abf8e5");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "3f867ec4-bf5a-4f83-b330-63fc1af3968a");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "44b50da0-1a6d-4df3-8538-0185c2e9e5b8");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "622e953a-1706-44cf-b512-00ca87c7054f");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "8195b8f6-1ce1-4d5e-990c-d638475906ca");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "98363f4e-59fb-4929-b33f-a8b41413a59c");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "99e6660f-7cbe-408e-816e-4884e36710a3");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "a1f50cf9-1d0e-4a8b-aed8-f786fa183871");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "a9a93533-04fe-4393-ab00-b2b38a6fd4c7");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "acf21d61-127e-43c9-a826-42b3a1f9c27a");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "b304ceea-354a-48a5-9fd4-cfbaba3ed807");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "ba93de1a-3b88-412f-bf99-25f0b05e8fba");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "bf909ffa-8185-4667-8305-106bf0da54a7");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "f289bd58-6f6d-4e14-bf6a-098f53828b06");

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: "f510e273-0b21-49a2-913d-f183cabd1ba2");

            migrationBuilder.DeleteData(
                table: "surveys",
                keyColumn: "id",
                keyValue: "2091f48c-a6a6-4c03-b1cd-75d4488c06aa");

            migrationBuilder.DeleteData(
                table: "surveys",
                keyColumn: "id",
                keyValue: "273f4d05-315b-48e5-8938-4746bab72b5c");

            migrationBuilder.DeleteData(
                table: "surveys",
                keyColumn: "id",
                keyValue: "53ddc52b-0cfe-4de4-b353-30ff6f0d8133");

            migrationBuilder.DeleteData(
                table: "surveys",
                keyColumn: "id",
                keyValue: "b66d55d6-61d9-403b-b22f-0cab26599468");

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "id",
                keyValue: "0929179e-ae8c-4bfc-826a-57c69b0de18c");

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "id",
                keyValue: "8f19e9a6-5538-403a-bbfa-9bf4d3d67934");

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "id",
                keyValue: "e1a9cebb-661b-475a-9ae3-323883e497eb");

            migrationBuilder.DeleteData(
                table: "rewards",
                keyColumn: "id",
                keyValue: "053330d5-6641-4006-acf8-7d9b11fa1fa7");

            migrationBuilder.DeleteData(
                table: "rewards",
                keyColumn: "id",
                keyValue: "3fbc03c5-da3d-4326-89c9-4a21f601c19d");

            migrationBuilder.DeleteData(
                table: "rewards",
                keyColumn: "id",
                keyValue: "5558e8e0-7736-4a40-9153-b6b6ba2c6679");

            migrationBuilder.RenameTable(
                name: "respondent_rewards",
                newName: "respondent_reward");

            migrationBuilder.RenameIndex(
                name: "ix_respondent_rewards_respondent_id",
                table: "respondent_reward",
                newName: "ix_respondent_reward_respondent_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_respondent_reward",
                table: "respondent_reward",
                column: "id");

            migrationBuilder.InsertData(
                table: "companies",
                columns: new[] { "id", "logo_src", "name" },
                values: new object[,]
                {
                    { "5046df65-b65e-4a6b-bb8a-e05c1b21f4e3", "https://silpo.ua/images/silpo_fb_share.png", "Сільпо" },
                    { "57d591d7-b380-4763-8615-58231b984942", "https://allretail.ua/static/files/originals/2/85/30b01f786bd9a28d98e745247184f852.svg", "АТБ" },
                    { "75fcdb74-bee8-4441-bab0-7225a7553ea2", "https://cdn.metro-online.com/-/media/Project/MCW/RU_Metro/2021/join-us/Metro.png?rev=fe69769d14aa4105bc7e5731e32ebfc7&w=339&hash=783A0BB0789E586BB438C44B0778558A", "Metro" }
                });

            migrationBuilder.InsertData(
                table: "rewards",
                columns: new[] { "id", "content" },
                values: new object[,]
                {
                    { "3e4c4aeb-80c4-4120-8885-b6e566ee368f", "Знижка 10% на наступну покупку" },
                    { "3ff1ce43-d650-4ea8-a409-cfe4c6170988", "+100 грн" },
                    { "7b128dcf-8520-4c18-ac6c-75e6bd1cb349", "Промокод -50% на чернігівське титан zxcqw-e13371000-7wwww" },
                    { "9d787398-4942-42e2-9ed1-c56f96326644", "Безкоштовна доставка при наступному замовленні" }
                });

            migrationBuilder.InsertData(
                table: "surveys",
                columns: new[] { "id", "company_id", "description", "reward_id", "title" },
                values: new object[,]
                {
                    { "36d380a6-7007-4928-9e00-ca3c9a1acf14", "5046df65-b65e-4a6b-bb8a-e05c1b21f4e3", "Опитування про ваші уподобання щодо пива", "7b128dcf-8520-4c18-ac6c-75e6bd1cb349", "Споживання пива" },
                    { "3828d7fc-7b50-4da6-8884-599db176a644", "75fcdb74-bee8-4441-bab0-7225a7553ea2", "Допоможіть нам визначити найпопулярніший продукт в Metro", "3ff1ce43-d650-4ea8-a409-cfe4c6170988", "Найкращий продукт" },
                    { "46cdf134-5d3b-4dfb-9dfb-039681eb932f", "57d591d7-b380-4763-8615-58231b984942", "Щоб покращити обслуговування, просимо вас взяти участь в нашому опитуванні", "3e4c4aeb-80c4-4120-8885-b6e566ee368f", "Ваші покупки в АТБ" },
                    { "51fb15c3-a702-41a6-8653-40b1cbd5e628", "57d591d7-b380-4763-8615-58231b984942", "Оцініть якість обслуговування в наших магазинах", "3e4c4aeb-80c4-4120-8885-b6e566ee368f", "Якість обслуговування" }
                });

            migrationBuilder.InsertData(
                table: "questions",
                columns: new[] { "id", "survey_id", "title" },
                values: new object[,]
                {
                    { "08b47494-defb-4bf6-b5f7-d861d0f01e59", "51fb15c3-a702-41a6-8653-40b1cbd5e628", "Чи радите ви своїм знайомим відвідувати магазини АТБ?" },
                    { "15e8db4e-bb53-4164-8ac9-0e1e995d2e1f", "51fb15c3-a702-41a6-8653-40b1cbd5e628", "Чи допомагає вам персонал з пошуком товарів?" },
                    { "2d6da8e2-dc0b-47e7-962b-b8cd3997eba5", "46cdf134-5d3b-4dfb-9dfb-039681eb932f", "Які товари ви найчастіше купуєте в наших магазинах?" },
                    { "2fec5013-2680-43a6-8621-40d14ec904c0", "46cdf134-5d3b-4dfb-9dfb-039681eb932f", "Як часто ви здійснюєте покупки в АТБ?" },
                    { "482e42f4-f116-4b47-b0ae-10b70354755d", "3828d7fc-7b50-4da6-8884-599db176a644", "Який продукт ви купуєте найчастіше в Metro?" },
                    { "488e1580-2be8-4224-a479-035586148414", "36d380a6-7007-4928-9e00-ca3c9a1acf14", "Як часто ви купуєте пиво в наших магазинах?" },
                    { "4c6005ec-2113-45f8-a244-44b46fc41e71", "36d380a6-7007-4928-9e00-ca3c9a1acf14", "Чи спробували ви нові сорти пива в нашому магазині?" },
                    { "5aa48f79-3caa-4536-ab92-6675a5ce19cc", "3828d7fc-7b50-4da6-8884-599db176a644", "Які характеристики товарів важливі для вас при покупці?" },
                    { "6d3d0979-35c7-47e7-ad80-56b5fe36307b", "36d380a6-7007-4928-9e00-ca3c9a1acf14", "Яке пиво ви купуєте найчастіше?" },
                    { "81638814-b787-486a-a9c9-610b8a16d3e1", "3828d7fc-7b50-4da6-8884-599db176a644", "Як часто ви відвідуєте наші магазини?" },
                    { "9dca22e2-4bd9-4a82-882a-f19835c95118", "46cdf134-5d3b-4dfb-9dfb-039681eb932f", "Чи вважаєте ви наші ціни конкурентоспроможними?" },
                    { "ab44fa3d-7ab9-41e2-9592-9ea7b99bf39b", "36d380a6-7007-4928-9e00-ca3c9a1acf14", "Які характеристики пива важливі для вас?" },
                    { "c085cd1d-4894-43f8-b383-d17371636f1c", "51fb15c3-a702-41a6-8653-40b1cbd5e628", "Як ви оцінюєте чистоту наших магазинів?" },
                    { "c82ae074-05e3-4b6f-8789-e951720658a0", "3828d7fc-7b50-4da6-8884-599db176a644", "Чи задоволені ви асортиментом товарів у наших магазинах?" },
                    { "cb1f165b-2950-481b-91a2-89174acad2b8", "51fb15c3-a702-41a6-8653-40b1cbd5e628", "Чи вважаєте ви, що у нас завжди є необхідні товари?" },
                    { "d504962b-d5ef-4d58-af58-606a2c852610", "46cdf134-5d3b-4dfb-9dfb-039681eb932f", "Чи задоволені ви якістю обслуговування у наших магазинах?" }
                });

            migrationBuilder.InsertData(
                table: "answers",
                columns: new[] { "id", "content", "question_id" },
                values: new object[,]
                {
                    { "02d1740d-c0f3-4a38-8338-099b021e25b1", "Відповідь 78", "6d3d0979-35c7-47e7-ad80-56b5fe36307b" },
                    { "02d3824d-1fdc-429f-86d8-b6e8834618b2", "Відповідь 15", "9dca22e2-4bd9-4a82-882a-f19835c95118" },
                    { "035b0589-bb77-4677-80f2-4e0d0c07dd9f", "Відповідь 32", "5aa48f79-3caa-4536-ab92-6675a5ce19cc" },
                    { "035c7b92-52f7-4956-ae6e-df0ddb90234d", "Відповідь 23", "15e8db4e-bb53-4164-8ac9-0e1e995d2e1f" },
                    { "041d77e3-11ca-4835-a373-b3f8d6e73ae5", "Відповідь 50", "2fec5013-2680-43a6-8621-40d14ec904c0" },
                    { "0eee8e4b-de17-4294-b0a2-ce763c90b710", "Відповідь 67", "2d6da8e2-dc0b-47e7-962b-b8cd3997eba5" },
                    { "164034e6-5e6a-4c26-97c2-a7a492cfc342", "Відповідь 44", "9dca22e2-4bd9-4a82-882a-f19835c95118" },
                    { "16dbc31f-bad6-4766-84d2-6cad3a765fb8", "Відповідь 89", "c085cd1d-4894-43f8-b383-d17371636f1c" },
                    { "1a693c72-99c1-4da8-b866-47ad7bf3389a", "Відповідь 14", "d504962b-d5ef-4d58-af58-606a2c852610" },
                    { "1c7a3485-b003-43dc-a7ca-b10731670108", "Відповідь 75", "482e42f4-f116-4b47-b0ae-10b70354755d" },
                    { "1f0d7cb1-c83a-4381-88c8-8448ee7b0ad5", "Відповідь 21", "c82ae074-05e3-4b6f-8789-e951720658a0" },
                    { "1f9d897c-9167-483c-b12b-d932f44d988b", "Відповідь 60", "5aa48f79-3caa-4536-ab92-6675a5ce19cc" },
                    { "247861f5-b31c-45be-9099-fd40793f60a9", "Відповідь 89", "81638814-b787-486a-a9c9-610b8a16d3e1" },
                    { "2956b1cf-6562-470a-9cb2-5d5af59aa3ac", "Відповідь 40", "6d3d0979-35c7-47e7-ad80-56b5fe36307b" },
                    { "2e0cc471-f6e5-4354-bb03-f3e607bfaa8f", "Відповідь 6", "c82ae074-05e3-4b6f-8789-e951720658a0" },
                    { "31662ed9-4990-4930-9401-eb50813f6d62", "Відповідь 20", "2fec5013-2680-43a6-8621-40d14ec904c0" },
                    { "3213a5cd-fc99-4b9d-9b28-1e190e13a88f", "Відповідь 49", "4c6005ec-2113-45f8-a244-44b46fc41e71" },
                    { "36a4531b-e7e3-4efd-8b8d-94ea6a95a242", "Відповідь 34", "d504962b-d5ef-4d58-af58-606a2c852610" },
                    { "3a3c51c6-3d34-4902-bef6-fc2f0c7031ae", "Відповідь 63", "81638814-b787-486a-a9c9-610b8a16d3e1" },
                    { "3c1bcff9-bede-4bc8-940f-863e7f735634", "Відповідь 65", "15e8db4e-bb53-4164-8ac9-0e1e995d2e1f" },
                    { "3e9e54d6-074d-48f7-bfcf-472f5b2089c2", "Відповідь 3", "c085cd1d-4894-43f8-b383-d17371636f1c" },
                    { "3fba1b3f-8222-4d9d-947f-1da856ce948c", "Відповідь 19", "2fec5013-2680-43a6-8621-40d14ec904c0" },
                    { "4e1c1d98-fb05-41f9-9e70-cff217e1c787", "Відповідь 87", "9dca22e2-4bd9-4a82-882a-f19835c95118" },
                    { "51ec36b7-1259-45b1-afc4-5b4b94db281d", "Відповідь 83", "2d6da8e2-dc0b-47e7-962b-b8cd3997eba5" },
                    { "5a972830-996b-4d0c-a696-e529db2d1264", "Відповідь 28", "5aa48f79-3caa-4536-ab92-6675a5ce19cc" },
                    { "5b2d53b9-0215-4b80-9b41-4e11b9ed492b", "Відповідь 72", "cb1f165b-2950-481b-91a2-89174acad2b8" },
                    { "60e83f56-8c87-4947-9dfc-bfddd3ee6b87", "Відповідь 53", "08b47494-defb-4bf6-b5f7-d861d0f01e59" },
                    { "6ab56bac-2016-4752-8ece-f5e66301defe", "Відповідь 22", "ab44fa3d-7ab9-41e2-9592-9ea7b99bf39b" },
                    { "7507f6d8-8395-4905-9426-853d4b506c53", "Відповідь 38", "c82ae074-05e3-4b6f-8789-e951720658a0" },
                    { "77fd9ab9-6d54-4eb1-8970-8a1b8e89c60b", "Відповідь 74", "ab44fa3d-7ab9-41e2-9592-9ea7b99bf39b" },
                    { "7ba6bdf7-59b2-4ebf-8818-429cb73b1661", "Відповідь 36", "9dca22e2-4bd9-4a82-882a-f19835c95118" },
                    { "7e878d7b-8d17-4757-a5de-7446e0001743", "Відповідь 87", "5aa48f79-3caa-4536-ab92-6675a5ce19cc" },
                    { "8368d15c-a9aa-4a54-99c7-91e1a0be6b72", "Відповідь 32", "4c6005ec-2113-45f8-a244-44b46fc41e71" },
                    { "838689c3-d16d-4d3f-8dae-5208145b21a7", "Відповідь 49", "08b47494-defb-4bf6-b5f7-d861d0f01e59" },
                    { "83f26dff-93c1-43e9-a758-0fdef393d5d5", "Відповідь 34", "4c6005ec-2113-45f8-a244-44b46fc41e71" },
                    { "891f8a89-a793-41e3-8d75-9f4deea608d6", "Відповідь 50", "482e42f4-f116-4b47-b0ae-10b70354755d" },
                    { "8ac2ab72-2fa8-42ec-a8f6-902e4bacb882", "Відповідь 48", "488e1580-2be8-4224-a479-035586148414" },
                    { "8cc2353b-0c64-4a11-a315-dcc8bc1c487b", "Відповідь 62", "6d3d0979-35c7-47e7-ad80-56b5fe36307b" },
                    { "9f50ab0e-dd5c-4155-ab5d-0b4aba19b911", "Відповідь 92", "c82ae074-05e3-4b6f-8789-e951720658a0" },
                    { "a1a1dd31-2700-426b-817b-bdc42dd29b53", "Відповідь 88", "cb1f165b-2950-481b-91a2-89174acad2b8" },
                    { "a4ae58c7-8b8c-4fd5-95d8-8e1525b94fc2", "Відповідь 50", "6d3d0979-35c7-47e7-ad80-56b5fe36307b" },
                    { "a8096540-834c-4f95-9317-fa5773d3676b", "Відповідь 81", "cb1f165b-2950-481b-91a2-89174acad2b8" },
                    { "a8e6c2b9-658f-4058-8be0-775d86d179e1", "Відповідь 8", "c085cd1d-4894-43f8-b383-d17371636f1c" },
                    { "aa96bda8-a222-4223-b724-b906e96a68bc", "Відповідь 73", "15e8db4e-bb53-4164-8ac9-0e1e995d2e1f" },
                    { "ad851c3c-4317-4a5c-94c5-5fa521d405d8", "Відповідь 36", "2fec5013-2680-43a6-8621-40d14ec904c0" },
                    { "adab1c34-8076-4e46-b088-3998d44b3f34", "Відповідь 21", "482e42f4-f116-4b47-b0ae-10b70354755d" },
                    { "b47fd5b3-3717-4c45-801b-5843699066d5", "Відповідь 35", "08b47494-defb-4bf6-b5f7-d861d0f01e59" },
                    { "b9b9cdae-2131-497d-b678-4786b5ad00fb", "Відповідь 63", "ab44fa3d-7ab9-41e2-9592-9ea7b99bf39b" },
                    { "bb06a73a-0cce-49c3-a0d3-503e71ab6855", "Відповідь 48", "15e8db4e-bb53-4164-8ac9-0e1e995d2e1f" },
                    { "c2e77091-974a-4019-8424-39f881314f70", "Відповідь 41", "488e1580-2be8-4224-a479-035586148414" },
                    { "d66db0c9-2e9a-4ff0-863c-64b44f52c990", "Відповідь 59", "2d6da8e2-dc0b-47e7-962b-b8cd3997eba5" },
                    { "d7fe748b-51a3-41b8-be5d-bb7e94767795", "Відповідь 19", "d504962b-d5ef-4d58-af58-606a2c852610" },
                    { "df821a9e-97fc-4075-a42a-5c03f4587152", "Відповідь 94", "81638814-b787-486a-a9c9-610b8a16d3e1" },
                    { "e2f87636-f079-436f-ae6d-0f5a92539dd7", "Відповідь 70", "488e1580-2be8-4224-a479-035586148414" },
                    { "e433759e-1a15-4f13-a476-549581b071de", "Відповідь 83", "d504962b-d5ef-4d58-af58-606a2c852610" },
                    { "e4489d91-6fa4-43a2-8a84-fffa3199e8fd", "Відповідь 62", "08b47494-defb-4bf6-b5f7-d861d0f01e59" },
                    { "e7c4c6b2-2313-4f24-9c86-2c25e3e22557", "Відповідь 26", "cb1f165b-2950-481b-91a2-89174acad2b8" },
                    { "e8d12e13-61d1-4c28-be6b-20a5b452631f", "Відповідь 12", "4c6005ec-2113-45f8-a244-44b46fc41e71" },
                    { "ed4e2d0e-8dca-49fe-84f3-3b2244fe67c7", "Відповідь 50", "c085cd1d-4894-43f8-b383-d17371636f1c" },
                    { "f0e5d721-eced-408a-92cf-3d371daf5412", "Відповідь 83", "2d6da8e2-dc0b-47e7-962b-b8cd3997eba5" },
                    { "f8c0c73a-9fb3-4b3a-a6ab-10e445820812", "Відповідь 64", "81638814-b787-486a-a9c9-610b8a16d3e1" },
                    { "f9dd026a-c159-4040-8c3b-4995e9ada2af", "Відповідь 58", "488e1580-2be8-4224-a479-035586148414" },
                    { "fb381457-622e-4ebe-9d09-26859ae0a806", "Відповідь 96", "482e42f4-f116-4b47-b0ae-10b70354755d" },
                    { "ff7cc8eb-0122-4967-9fd2-402b56db97a9", "Відповідь 24", "ab44fa3d-7ab9-41e2-9592-9ea7b99bf39b" }
                });

            migrationBuilder.AddForeignKey(
                name: "fk_respondent_reward_respondents_respondent_id",
                table: "respondent_reward",
                column: "respondent_id",
                principalTable: "respondents",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
