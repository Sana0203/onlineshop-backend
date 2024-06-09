using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using OnlineShopBackend.APIs;
using OnlineShopBackend.DB;
using OnlineShopBackend.Entities;
using OnlineShopBackend.Infrastructure;
using OnlineShopBackend.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MyOnlineShopDB>(options=>{
    options.UseSqlite("Data Source=./MyOnlineShopDB.db");
});
builder.Services.AddScoped<IRepository<Customer>, GenericRepository<Customer>>();
builder.Services.AddScoped<IRepository<Product>, GenericRepository<Product>>();
builder.Services.AddScoped<IRepository<ProductCategories>, GenericRepository<ProductCategories>>();
builder.Services.AddScoped<IRepository<Order>, GenericRepository<Order>>();
builder.Services.AddScoped<IRepository<OrderDetails>, GenericRepository<OrderDetails>>();
builder.Services.AddScoped<IRepository<CustomerCard>, GenericRepository<CustomerCard>>();
builder.Services.AddScoped<IRepository<Payment>, GenericRepository<Payment>>();
builder.Services.AddScoped<IRepository<Bill>, GenericRepository<Bill>>();
builder.Services.AddScoped<IRepository<Pending>, GenericRepository<Pending>>();
builder.Services.AddScoped<IRepository<Processing>, GenericRepository<Processing>>();
builder.Services.AddScoped<IRepository<Shipped>, GenericRepository<Shipped>>();
builder.Services.AddCors();

var app = builder.Build();

app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//with include, an inner join happens for getting the data form relations.
app.MapCrud<Customer>("customers");
app.MapCrud<Product>("products",includes:["ProductCategories"]);
app.MapCrud<ProductCategories>("productCategories");
app.MapCrud<Order>("orders",includes:["Customer","OrderStatus"]);
app.MapCrud<OrderDetails>("orderdetails",includes:["Product","Order","Order.Customer","Order.OrderStatus"]);
app.MapCrud<CustomerCard>("customercards",includes:["Customer"]);
app.MapCrud<Payment>("payments",includes:["Bill","CustomerCard"]);
app.MapCrud<Bill>("bills",includes:["Order"]);
app.MapCrud<Pending>("pendingorders");
app.MapCrud<Processing>("processingorders");
app.MapCrud<Shipped>("shippedorders");




app.Run();

