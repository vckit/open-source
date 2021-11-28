using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceSystem.Model;

namespace FinanceSystem.Context
{
    internal static class dbContext
    {
        internal static dbFinanceAppEntities db = new dbFinanceAppEntities();
    }
}
