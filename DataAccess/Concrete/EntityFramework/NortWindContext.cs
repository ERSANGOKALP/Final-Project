using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class NortWindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localDB\mssqlLocalDb(sqlserver 13.0.4001.0-casper\administrator");

        }
    }
    public DbSet<Product> Products { get; set; }

    public DbSet<Product> Categories { get; set; }

    public DbSet<Product> Customers { get; set; }


}
