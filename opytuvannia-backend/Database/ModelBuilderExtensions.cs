using Microsoft.EntityFrameworkCore;
using opytuvannia_backend.Entities;
using System;
using System.Collections.Generic;

namespace opytuvannia_backend.Database
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var silpo = new Company { Name = "Сільпо", LogoSrc = "https://silpo.ua/images/silpo_fb_share.png" };
            var metro = new Company { Name = "Metro", LogoSrc = "https://cdn.metro-online.com/-/media/Project/MCW/RU_Metro/2021/join-us/Metro.png?rev=fe69769d14aa4105bc7e5731e32ebfc7&w=339&hash=783A0BB0789E586BB438C44B0778558A" };
            var atb = new Company { Name = "АТБ", LogoSrc = "https://allretail.ua/static/files/originals/2/85/30b01f786bd9a28d98e745247184f852.svg" };

            modelBuilder.Entity<Company>().HasData(silpo, metro, atb);

            var rewards = new List<Reward>
            {
                new() { Content = "Промокод -50% на чернігівське титан zxcqw-e13371000-7wwww" },
                new() { Content = "+100 грн" },
                new() { Content = "Знижка 10% на наступну покупку" },
                new() { Content = "Безкоштовна доставка при наступному замовленні" }
            };

            modelBuilder.Entity<Reward>().HasData(rewards);
            
            var silpoSurvey = new Survey { CompanyId = silpo.Id, Title = "Споживання пива", Description = "Опитування про ваші уподобання щодо пива", RewardId = rewards[0].Id };
            var metroSurvey = new Survey { CompanyId = metro.Id, Title = "Найкращий продукт", Description = "Допоможіть нам визначити найпопулярніший продукт в Metro", RewardId = rewards[1].Id  };
            var atbSurvey = new Survey { CompanyId = atb.Id, Title = "Ваші покупки в АТБ", Description = "Щоб покращити обслуговування, просимо вас взяти участь в нашому опитуванні", RewardId = rewards[2].Id };
            var atbSurvey2 = new Survey { CompanyId = atb.Id, Title = "Якість обслуговування", Description = "Оцініть якість обслуговування в наших магазинах", RewardId = rewards[2].Id };

            modelBuilder.Entity<Survey>().HasData(silpoSurvey, metroSurvey, atbSurvey, atbSurvey2);

            var silpoQuestions = new List<Question>
            {
                new Question { SurveyId = silpoSurvey.Id, Title = "Яке пиво ви купуєте найчастіше?" },
                new Question { SurveyId = silpoSurvey.Id, Title = "Чи спробували ви нові сорти пива в нашому магазині?" },
                new Question { SurveyId = silpoSurvey.Id, Title = "Які характеристики пива важливі для вас?" },
                new Question { SurveyId = silpoSurvey.Id, Title = "Як часто ви купуєте пиво в наших магазинах?" }
            };

            var metroQuestions = new List<Question>
            {
                new Question { SurveyId = metroSurvey.Id, Title = "Який продукт ви купуєте найчастіше в Metro?" },
                new Question { SurveyId = metroSurvey.Id, Title = "Чи задоволені ви асортиментом товарів у наших магазинах?" },
                new Question { SurveyId = metroSurvey.Id, Title = "Які характеристики товарів важливі для вас при покупці?" },
                new Question { SurveyId = metroSurvey.Id, Title = "Як часто ви відвідуєте наші магазини?" }
            };

            var atbQuestions = new List<Question>
            {
                new Question { SurveyId = atbSurvey.Id, Title = "Як часто ви здійснюєте покупки в АТБ?" },
                new Question { SurveyId = atbSurvey.Id, Title = "Які товари ви найчастіше купуєте в наших магазинах?" },
                new Question { SurveyId = atbSurvey.Id, Title = "Чи задоволені ви якістю обслуговування у наших магазинах?" },
                new Question { SurveyId = atbSurvey.Id, Title = "Чи вважаєте ви наші ціни конкурентоспроможними?" }
            };

            var atbQuestions2 = new List<Question>
            {
                new Question { SurveyId = atbSurvey2.Id, Title = "Як ви оцінюєте чистоту наших магазинів?" },
                new Question { SurveyId = atbSurvey2.Id, Title = "Чи допомагає вам персонал з пошуком товарів?" },
                new Question { SurveyId = atbSurvey2.Id, Title = "Чи вважаєте ви, що у нас завжди є необхідні товари?" },
                new Question { SurveyId = atbSurvey2.Id, Title = "Чи радите ви своїм знайомим відвідувати магазини АТБ?" }
            };
            
            modelBuilder.Entity<Question>().HasData(silpoQuestions.Concat(metroQuestions).Concat(atbQuestions).Concat(atbQuestions2));

            var random = new Random();
            var answers = new List<Answer>();
            
            foreach (var question in silpoQuestions.Concat(metroQuestions).Concat(atbQuestions).Concat(atbQuestions2))
            {
                for (int i = 0; i < 4; i++)
                {
                    answers.Add(new Answer
                    {
                        QuestionId = question.Id,
                        Content = $"Відповідь {random.Next(1, 100)}"
                    });
                }
            }
            
            modelBuilder.Entity<Answer>().HasData(answers);
        }
    }
}
