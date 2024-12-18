using Microsoft.EntityFrameworkCore;
using RatGameApi.Repositories;
using RatGameApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<HighScoresService>();
builder.Services.AddScoped<TestsService>();
builder.Services.AddScoped<HighScoresRepository>();
builder.Services.AddScoped<TestsRepository>();

var connectionString = builder.Configuration.GetConnectionString("RatGameDb");
builder.Services.AddDbContext<RatGameContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddControllers();

builder.Services.AddCors(options => options.AddDefaultPolicy(builder => builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader()));

var app = builder.Build();

app.MapControllers();

app.UseCors();

app.Run();
