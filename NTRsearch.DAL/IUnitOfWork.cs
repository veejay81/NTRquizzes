using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NTRsearch.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
    }
}
