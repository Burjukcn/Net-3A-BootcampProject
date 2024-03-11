using Core.CrossCuttingConcerns.Logging.Serilog.ConfigurationModels;
using Core.Utilities.IoC;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Logging.Serilog.Loggers
{
    public class MongoDbLogger : LoggerServiceBase
    {
        public MongoDbLogger()
        {
            var configuration = ServiceTool.ServiceProvider.GetRequiredService<IConfiguration>();
            var logConfig = configuration.GetSection("SerilogConfigurations:MongoDbConfiguration").Get<MongoDbConfiguration>();

            Logger = new LoggerConfiguration()
              .WriteTo.MongoDB(logConfig.ConnectionString, collectionName: logConfig.Collection)
              .CreateLogger();
        }
    }
}