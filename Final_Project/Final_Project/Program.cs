using Final_Project.Data;
using Final_Project.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApiDocument();
//builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<studentDBContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
//builder.Services.AddOpenApiDocument();
builder.Services.AddScoped<IStudentsContextDAO, StudentsContextDAO>();
builder.Services.AddScoped<IFastFoodContextDAO, FastFoodContextDAO>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();
    //app.UseSwagger();
    app.UseSwaggerUi3();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
