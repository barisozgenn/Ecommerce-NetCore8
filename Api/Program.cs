using System.Text;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.DependencyResolver.Autofac;
using Core.DependencyResolver;
using Core.Extensions;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

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

/*
//Site bazlı izin vermek istiyorsak
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin", builder => builder.WithOrigins("https://localhost:5001"));//gelen tüm isteklere izin vermek istiyorsak allow kullanırız
}); */

//Eğer tüm istekleri karşılamak istiyorsak ve app use cors ayarlarımızı da build' ten sonrasına ekledik ekledik

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin", builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());//gelen tüm isteklere izin vermek istiyoruz
});

//JWT token ayarlarını yapalım buna schema yazmak mümkün ama default bize yeter ilk etapta
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateAudience = true,//oluşturulacak tokeni kontrol etmeli miyim
        ValidateIssuer = true,//oluşuturulacak tokeninin dağıtıcını söyleyeyim mi
        ValidateLifetime = false,//token e tanımlanmış life time expire olmuşsa tokeni doğrulama, biz false yaptık çünkü performans için daha iyi zaten güvenlik önlemlerimiz var
        ValidateIssuerSigningKey = true,// ürütelecek tokenin bizim uygulamaya ait olduğunun doğrulanmasıdır
        ValidIssuer = builder.Configuration["Token:Issuer"],//oluşturacağımız token yapısında Issuer değerine sahip olacaksınbunları appsetting.json dan oku
        ValidAudience = builder.Configuration["Token:Audience"],//bunları appsetting.json dan oku
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:SecurityKey"])),// bunları appsetting.json dan oku
        ClockSkew = TimeSpan.Zero // server ile zaman farkı olursa bunu 5 veya 10 yaparız
    };
});

//Memory cache için hazırladığımız service tool ları dahil edelim
builder.Services.AddDependencyResolvers(new ICoreModule[]
{
    new CoreModule()
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


app.ConfigureCustomExceptionMiddleware();//excepitonlar için oluşturduğumuz custom middleware extensionu işle

app.UseCors("AllowOrigin");//cors ayarlarımızı buraya ekledik

app.UseHttpsRedirection();

app.UseAuthentication();//Token var mı yok mu tespit edilir [Authorize(role adı yazılır)]
app.UseAuthorization();//Erişilmek istenen bölümü görüntülemeye yetkisi var mı yok mu kontrol edilir, rol kontrolü

app.MapControllers();

app.Run();

