using EM24.Core.Interfaces.DomainServices;
using EM24.Core.Interfaces.Repositories;
using EM24.Core.Services;
using EM24.Infrastructure.Data;
using EM24.Web.Interfaces;
using EM24.Web.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//CORS
const string policyName = "AllowOrigin";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: policyName,
        corsPolicyBuilder =>
        {
            corsPolicyBuilder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
});

//DBContext
builder.Services.AddDbContext<EmContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbContext"));
});

//API Controllers
builder.Services.AddControllers();

//Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Build repositories
builder.Services.AddScoped(typeof(IReadRepository<>), typeof(EfReadRepository<>));
builder.Services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));


//Build services
builder.Services.AddScoped<IPlayerService, PlayerService>();
builder.Services.AddScoped<IGameService, GameService>();

//Build view model services
builder.Services.AddScoped<IPlayerViewModelService, PlayerViewModelService>();

var app = builder.Build();

app.UseStaticFiles(); //For wwwroot frontend build
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors(policyName);
app.UseHttpsRedirection();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();