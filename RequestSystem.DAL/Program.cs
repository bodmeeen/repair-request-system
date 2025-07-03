using Microsoft.EntityFrameworkCore;
using RequestSystem.DAL.Data;
using RequestSystem.DAL.Repositories.Interfaces;
using RequestSystem.DAL.Repositories;
using RequestSystem.DAL.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDBContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IRepairRequestRepository, RepairRequestRepository>();


var app = builder.Build();

app.MapControllers();

app.Run();
