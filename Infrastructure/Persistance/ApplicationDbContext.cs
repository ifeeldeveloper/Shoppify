using Application.Common.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ): base(options)
        {
        }
        public DbSet<Product> Products => Set<Product>();


        //public DbSet<Product> Products => Set<Product>();        

        //  DbSet<Product> IApplicationDbContext.Products => Set<Product>();
    }
}
