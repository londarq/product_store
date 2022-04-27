using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;

namespace DAL.Context
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            //TODO: remove hardcode
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=product_store;Persist Security Info=True;User ID=sa;Password=sa"/*, opts => opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds)*/);
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
