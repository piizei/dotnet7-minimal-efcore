using System.Reflection;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using rest2.Features.Users;
using rest2.Infrastructure;
using rest2.Infrastructure.User;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCarter();
builder.Services.AddDbContext<MSSqlDbContext>(options  =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddScoped<IGetUsersQuery, GetUsersQuery>();
builder.Services
    .AddAutoMapper(Assembly.GetEntryAssembly());


var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    using var scope = app.Services.CreateScope();
    DbInitializer.Initialize(scope.ServiceProvider.GetRequiredService<MSSqlDbContext>());
    
}
app.MapCarter();
app.Run();