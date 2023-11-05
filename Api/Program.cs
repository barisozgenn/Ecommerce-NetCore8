using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.DependencyResolver.Autofac;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//old style dependency
/*
builder.Services.AddSingleton<IOperationClaimService, OperationClaimManager>();
builder. Services. AddSingleton<10perationClaimDal, EfOperationClaimDal>();
 */
//new and easy dependency Injection ları artık autofac ile container olarak yapıyoruz böylece progragram.cs şişmeyecek
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new AutofacBusinessModule()));

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();

