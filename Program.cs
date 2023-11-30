using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CityInfo.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CityInfoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CityInfoContext") ?? throw new InvalidOperationException("Connection string 'CityInfoContext' not found.")));

// Add services to the container.

builder.Services.AddControllers(options=>
{
    options.ReturnHttpNotAcceptable = true;
}).AddXmlDataContractSerializerFormatters();// we can add this line for Xml files
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
