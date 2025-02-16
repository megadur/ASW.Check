﻿using Serilog;

namespace WebApiFramework.utilities
{
    public static class SerilogHelper
    {
        public static readonly Serilog.ILogger _log;
        static SerilogHelper()
        {
            _log = new LoggerConfiguration().
                    ReadFrom.AppSettings().
                    CreateLogger();
        }

    }

}
