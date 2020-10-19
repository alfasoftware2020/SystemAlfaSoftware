using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AlfaSoftware.Models;

namespace AlfaSoftware.Data
{
    public class AlfaSoftwareContext : DbContext
    {
        public AlfaSoftwareContext (DbContextOptions<AlfaSoftwareContext> options)
            : base(options)
        {
        }

        public DbSet<AlfaSoftware.Models.ClientePF> ClientePF { get; set; }
    }
}
