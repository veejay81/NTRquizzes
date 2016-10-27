using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AsgSearch.DAL
{
    public class DB : DbContext
    {
        public DB() : base("ASGsearchDB") { }
        public DbSet<Query> Queries { get; set; }
    }
}
