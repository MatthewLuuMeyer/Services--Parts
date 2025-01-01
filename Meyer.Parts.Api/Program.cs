using Meyer.Parts;
using Meyer.Parts.DatabaseAccess;
using Meyer.Exceptions;
using Meyer.Services.Extensions;
using Meyer.Services.Extensions.Exceptions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Meyer.Exceptions.Connector;
using Meyer.Services.Extensions.Connectors;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Core
builder.AddSwaggerAndFluentValidation<Program>();
builder.Services.AddControllers();

// Database Configuration
var meyerConnectionString = builder.Configuration.GetSection("DatabaseConnectionStrings")["MeyerLogicReadWriteConnectionString"];
builder.Services.AddDbContext<PartsDatabaseContext>(options =>
{
    options.UseSqlServer(meyerConnectionString);
});

// Services Configuration
var servicesUrl = builder.Configuration.GetSection("ServiceUrls")["ReverseProxy"];
builder.Services.AddServiceHttpClient(servicesUrl);
builder.Services.AddScoped<IServiceExceptionsService, ServiceExceptionHttpService>();

// Project Services
builder.Services.AddScoped<IPartsService, PartsDatabaseService>();

// Core
var app = builder.Build();

app.AddSwagger();
app.MapControllers();
app.AddExceptionHandling("Amazon");

app.Run();