using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VendasWEBMVC1.Models
{
    public class VendasWEBMVC1Context : DbContext
    {
        public VendasWEBMVC1Context (DbContextOptions<VendasWEBMVC1Context> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}
