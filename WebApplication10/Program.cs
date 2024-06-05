using Microsoft.EntityFrameworkCore;
using WebApplication10.DbContexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProfileContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("ProfilesDB")));

builder.Services.AddTransient<ProfileContext, ProfileContext>();


builder.Services.AddDbContext<ProductContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("ProductsDB")));

builder.Services.AddTransient<ProductContext, ProductContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
