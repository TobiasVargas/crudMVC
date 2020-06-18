using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudMVC.Models;

namespace CrudMVC.Data
{
    public class CrudMVCContext : DbContext
    {
        public CrudMVCContext (DbContextOptions<CrudMVCContext> options)
            : base(options)
        {
        }

        public DbSet<CrudMVC.Models.Product> Product { get; set; }
    }
}
