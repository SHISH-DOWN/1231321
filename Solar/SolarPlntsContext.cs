using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar
{
    class PlanetsContext:DbContext

    {
        public PlanetsContext()
            : base("DbConnection")
        { }

        public DbSet<Planets> Planets { get; set; }
    }
}
