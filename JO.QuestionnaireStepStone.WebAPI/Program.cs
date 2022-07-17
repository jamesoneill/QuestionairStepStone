using JO.QuestionnaireStepStone.Core;
using JO.QuestionnaireStepStone.Data.Repository;
using JO.QuestionnaireStepStone.Interfaces.Core;
using JO.QuestionnaireStepStone.Interfaces.Data;

namespace JO.QuestionnaireStepStone.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IQuestionnaireRepository, QuestionnaireRepository>();
            builder.Services.AddScoped<IQuestionnaireService, QuestionnaireService>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}