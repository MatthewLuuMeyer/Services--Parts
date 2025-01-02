using Meyer.Parts;
using Meyer.Exceptions;
using Meyer.Services.Extensions;
using Meyer.Services.Extensions.Exceptions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Meyer.Exceptions.Connector;
using Meyer.Services.Extensions.Connectors;
using Microsoft.EntityFrameworkCore;
using Meyer.Parts.DatabaseAccess.Services;
using Meyer.Parts.DatabaseAccess.Database;
using AutoMapper;
using Meyer.Parts.DatabaseAccess.Database.Entities;
using Microsoft.Extensions.Hosting;
using Swashbuckle.AspNetCore.SwaggerUI;

internal class Program
{
    private const string _serviceName = "Parts Service";

    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Core
        builder.AddSwaggerAndFluentValidation<Program>();
        builder.Services.AddControllers();

        var autoMapperConfig = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<ItemQuantityMasterEntity, ItemQuantity>();
        });
        var autoMapper = autoMapperConfig.CreateMapper();
        builder.Services.AddSingleton(autoMapper);

        // Services Configuration
        var servicesUrl = builder.Configuration.GetSection("ServiceUrls")["ReverseProxy"];
        builder.Services.AddServiceHttpClient(servicesUrl);
        builder.Services.AddScoped<IServiceExceptionsService, ServiceExceptionHttpService>();

        builder.AddSwaggerAndFluentValidation<Program>();
        builder.Services.AddControllers();

        // Database Configuration
        var meyerConnectionString = builder.Configuration.GetSection("DatabaseConnectionStrings")["Meyer"];
        builder.Services.AddDbContext<PartsDatabaseContext>(options =>
        {
            options.UseSqlServer(meyerConnectionString);
        });

        // Project Services
        builder.Services.AddScoped<IPartsService, PartsService>();

        // Core
        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.AddSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", _serviceName);
                c.RoutePrefix = string.Empty;
                c.DocExpansion(DocExpansion.None);
            });
        }

        app.MapControllers();
        app.AddExceptionHandling(_serviceName);
        app.UseAuthorization();

        app.Run();
    }
}


