using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SampleCoreEFProject.Models
{
    public class SampleCoreEFProjectContext : DbContext
    {
        public SampleCoreEFProjectContext (DbContextOptions<SampleCoreEFProjectContext> options)
            : base(options)
        {
        }

        public DbSet<SampleCoreEFProject.Models.Product> Product { get; set; }
    }
}
