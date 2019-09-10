using IubShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IubShop.Database
{
    public class IubShopContext : DbContext
    {
        /*
         * EF Core -> ORM
         * SQL -> 
         * ORM -> Biblioteca para mapear objetos para banco de dados relacionais
         */
         public IubShopContext(DbContextOptions<IubShopContext> options) : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Newsletter> Newsletter { get; set; }
    }
}
