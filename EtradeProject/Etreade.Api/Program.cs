using Etreade.Dal;
using Etreade.Dto;
using Etreade.Entity;
using Etreade.Rep.Abstract;
using Etreade.Rep.Concretes;
using Etreade.Res;
using Etreade.Uow;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TreadContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("Connect")));
builder.Services.AddScoped<GeneralResponse>();
builder.Services.AddScoped<UserRespons>();
builder.Services.AddScoped<LoginDTO>();
builder.Services.AddScoped<BaskitMaster>();
builder.Services.AddScoped<BasketDetail>();
builder.Services.AddScoped<BasketDetailDTO>();
builder.Services.AddScoped<IBasketDetailRepos, BasketDetailRepos>();
builder.Services.AddScoped<IBasketMasterRepos, BasketMasterRepos>();
builder.Services.AddScoped<ICategoriesRepos, CategoriesRepos>();
builder.Services.AddScoped<IProductsRpos, ProductsRepos>();
builder.Services.AddScoped<ISuppliersRepos, SuppliersRepos>();
builder.Services.AddScoped<IUserRepos, UserRepos>();
builder.Services.AddScoped<IUow, Uow>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
