using ComercioElectronicoCQRS.Aplicacion;
using ComercioElectronicoCQRS.Dominio.Repositorios;
using ComercioElectronicoCQRS.Dominio.Servicios;
using ComercioElectronicoCQRS.Infraestructura;
using ComercioElectronicoCQRS.Infraestructura.Repositorios;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ComercioElectronicoContext>(dbContextOptions =>
        dbContextOptions.UseSqlServer(builder.Configuration.GetConnectionString("ComercioElectronicoCQRSConnectionString")));
builder.Services.AddTransient<IServicioProducto, ServicioProducto>();
builder.Services.AddTransient<ICompraServicio, CompraServicio>();
builder.Services.AddTransient<IClienteServicio, ClienteServicio>();
builder.Services.AddTransient<IProductoRepositorio, ProductosRepositorio>();
builder.Services.AddTransient<ICompraRepositorio, CompraRepositorio>();
builder.Services.AddTransient<IClienteRepositorio, ClienteRepositorio>();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(IAplicacionAnclas).Assembly));

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
