using APBD_T7_s33596.Application.Interfaces;
using APBD_T7_s33596.Application.Services;
using APBD_T7_s33596.Infrastructure.Db;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<IPcService, PcService>();

builder.Services.AddControllers(); builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); var app = builder.Build();

if (app.Environment.IsDevelopment())
{ 
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();