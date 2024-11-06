using ASW_Check.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASW.Check.Controllers
{

    public class CheckApiImpl
    {

        internal async Task<ICollection<Statusinfo>> PostDispensierungAsync(string value)
        {
            throw new NotImplementedException();
        }

        internal async Task<ICollection<ICollection<Statusinfo>>> PostDispensierungListAsync(IEnumerable<string> values)
        {
            throw new NotImplementedException();
        }

        internal async Task<Rezept> PostRezeptAsync(Rezept value)
        {
            throw new NotImplementedException();
        }

        internal async Task<ICollection<Rezept>> PostRezeptList(IEnumerable<Rezept> values)
        {
            throw new NotImplementedException();
        }
    }
}