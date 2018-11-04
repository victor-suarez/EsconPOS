using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsconPOS.classes
{
    class EmpleadosContext : DbContext
    {
        public DbSet<Identificaciones> Identificaciones { get; set; }
        public DbSet<Empleados> Empleados { get; set; }
    }
}
