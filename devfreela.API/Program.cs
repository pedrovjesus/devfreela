using devfreela.Application.Services.Implementations;
using devfreela.Application.Services.Interfaces;
using devfreela.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddSingleton<DevfreelaDbContext>();
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
