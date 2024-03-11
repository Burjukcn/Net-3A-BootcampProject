using Serilog.Sinks.MSSqlServer;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.CrossCuttingConcerns.Logging.Serilog.ConfigurationModels;
using Microsoft.Extensions.Configuration;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.CrossCuttingConcerns.Logging.Serilog.Loggers
{
    public class MssqlLogger : LoggerServiceBase
    {

        public MssqlLogger()
        {
            var configuration = ServiceTool.ServiceProvider.GetRequiredService<IConfiguration>();
            var logConfig = configuration.GetSection("SerilogConfigurations:MssqlConfiguration").Get<MssqlConfiguration>() ?? throw new Exception(SerilogMessages.NullOptionsMessage);
            MSSqlServerSinkOptions sinkOptions = new()
            { TableName = logConfig.TableName, AutoCreateSqlTable = logConfig.AutoCreateSqlTable };


            ColumnOptions columnOptions = new();
            global::Serilog.Core.Logger serilogConfig = new LoggerConfiguration().WriteTo
                .MSSqlServer(connectionString: logConfig.ConnectionString, sinkOptions: sinkOptions, columnOptions: columnOptions).CreateLogger();
            Logger = serilogConfig;


        }
    }
}
