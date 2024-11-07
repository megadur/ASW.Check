using ASW_Check.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using webapitemplate.utilities;

namespace ASW.Check.Controllers
{

    public class CheckApiImpl
    {
        private static readonly Serilog.ILogger log = SerilogHelper._log;
        internal async Task<ICollection<Statusinfo>> PostDispensierungAsync(string value)
        {
            log.Information("PostDispensierungAsync called with value: {value}", value);


            throw new NotImplementedException();
        }

        internal async Task<ICollection<ICollection<Statusinfo>>> PostDispensierungListAsync(IEnumerable<string> values)
        {
            log.Information("PostDispensierungListAsync called with values: {values}", values);
            throw new NotImplementedException();
        }

        internal async Task<Rezept> PostRezeptAsync(Rezept value)
        {
            log.Information("PostRezeptAsync called with value: {value}", value);
            throw new NotImplementedException();
        }

        internal async Task<ICollection<Rezept>> PostRezeptList(IEnumerable<Rezept> values)
        {
            log.Information("PostRezeptList called with values: {values}", values);
            throw new NotImplementedException();
        }
    }
}