using Microsoft.EntityFrameworkCore;
using server.Data;
using server.Implementations;
using server.Interfaces;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IPawbondPostsService, PawbondPostsService>();
builder.Services.AddScoped<IPawbondsService, PawbondsService>();
builder.Services.AddScoped<IPawpalsService, PawpalsService>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
                      policy =>
                      {policy.AllowAnyOrigin()
                                .AllowAnyMethod()
                                .AllowAnyHeader();});
});

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PawpalDbContext>(options => options.UseSqlite
(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
