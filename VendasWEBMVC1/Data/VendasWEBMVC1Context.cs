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

        public DbSet<VendasWEBMVC1.Models.Department> Department { get; set; }
    }
}
