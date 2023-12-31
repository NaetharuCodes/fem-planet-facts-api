using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;

builder.Services.AddDbContext<SolarSystemContext>(
    options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
);

// Add services to the container.
builder.Services.AddControllers();

// Add CORS services:
builder.Services.AddCors(options =>
{
    options.AddPolicy(
        "AllowSpecificOrigin",
        builder =>
        {
            builder
                .WithOrigins("http://localhost:3000") // Allow frontend origin
                .AllowAnyHeader()
                .AllowAnyMethod();
        }
    );
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowSpecificOrigin");
app.UseAuthorization();
app.MapControllers();

app.Run();
