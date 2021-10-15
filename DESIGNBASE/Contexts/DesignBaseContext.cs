using DESIGNBASE.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DESIGNBASE.Contexts
{
    public class DesignBaseContext : DbContext
    {
        public DesignBaseContext(DbContextOptions<DesignBaseContext> options) : base(options)
        {

        }
        public DbSet<ProjeGenel> ProjeGenel { get; set; }
    }
}
