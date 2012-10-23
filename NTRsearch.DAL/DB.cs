using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace NTRsearch.DAL
{
    public class DB : DbContext
    {
        public DB() : base("NTRsearchDB") { }
        public DbSet<Query> Queries { get; set; }
    }
}
