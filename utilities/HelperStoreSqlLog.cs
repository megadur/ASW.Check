using NpgsqlTypes;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.PostgreSQL;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace WebErrorLogging.Utilities
{
    public static class HelperStoreSqlLog
    {
        private static readonly ILogger Errorlog;
        private static readonly ILogger Warninglog;
        private static readonly ILogger Debuglog;
        private static readonly ILogger Verboselog;
        private static readonly ILogger Fatallog;
        private static readonly ILogger Informationlog;
        private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionStringLoggingPostgres"].ToString();
        private static readonly string tableName = "logs";

        //Used columns (Key is a column name) 
        //Column type is writer's constructor parameter
        private static readonly IDictionary<string, ColumnWriterBase> columnWriters = new Dictionary<string, ColumnWriterBase>
{
    {"message", new RenderedMessageColumnWriter(NpgsqlDbType.Text) },
    {"message_template", new MessageTemplateColumnWriter(NpgsqlDbType.Text) },
    {"level", new LevelColumnWriter(true, NpgsqlDbType.Varchar) },
    {"raise_date", new TimestampColumnWriter(NpgsqlDbType.Timestamp) },
    {"exception", new ExceptionColumnWriter(NpgsqlDbType.Text) },
    {"properties", new LogEventSerializedColumnWriter(NpgsqlDbType.Jsonb) },
    {"props_test", new PropertiesColumnWriter(NpgsqlDbType.Jsonb) },
    {"machine_name", new SinglePropertyColumnWriter("MachineName", PropertyWriteMethod.ToString, NpgsqlDbType.Text, "l") }
};
        static HelperStoreSqlLog()
        {

            Errorlog = new LoggerConfiguration()
                .MinimumLevel.Error()
                //.WriteTo.MSSqlServer(ConnectionString, tableName)
                .WriteTo.PostgreSQL(ConnectionString, tableName, columnWriters)
                .CreateLogger();

            Warninglog = new LoggerConfiguration()
                .MinimumLevel.Warning()
                .WriteTo.PostgreSQL(ConnectionString, tableName, columnWriters)
                .CreateLogger();

            Debuglog = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.PostgreSQL(ConnectionString, tableName, columnWriters)
                .CreateLogger();

            Verboselog = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.PostgreSQL(ConnectionString, tableName, columnWriters)
                .CreateLogger();

            Fatallog = new LoggerConfiguration()
                .MinimumLevel.Fatal()
                .WriteTo.PostgreSQL(ConnectionString, tableName, columnWriters)
                .CreateLogger();
            Informationlog = new LoggerConfiguration()
    .MinimumLevel.Information()
    .WriteTo.PostgreSQL(ConnectionString, tableName, columnWriters)
    .CreateLogger();
        }

        public static void WriteError(Exception ex, string message)
        {
            //Error - indicating a failure within the application or connected system
            Errorlog.Write(LogEventLevel.Error, ex, message);
        }

        public static void WriteWarning(Exception ex, string message)
        {
            //Warning - indicators of possible issues or service / functionality degradation
            Warninglog.Write(LogEventLevel.Warning, ex, message);
        }

        public static void WriteDebug(Exception ex, string message)
        {
            //Debug - internal control flow and diagnostic state dumps to facilitate pinpointing of recognised problems
            Debuglog.Write(LogEventLevel.Debug, ex, message);
        }

        public static void WriteVerbose(Exception ex, string message)
        {
            // Verbose - tracing information and debugging minutiae; generally only switched on in unusual situations
            Verboselog.Write(LogEventLevel.Verbose, ex, message);
        }

        public static void WriteFatal(Exception ex, string message)
        {
            //Fatal - critical errors causing complete failure of the application
            Fatallog.Write(LogEventLevel.Fatal, ex, message);
        }

        public static void WriteInformation(Exception ex, string message)
        {
            //Fatal - critical errors causing complete failure of the application
            Informationlog.Write(LogEventLevel.Information, ex, message);
        }
    }
}