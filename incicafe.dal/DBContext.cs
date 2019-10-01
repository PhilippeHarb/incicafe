using incicafe.bll;
using incicafe.dal.Entities;
using Microsoft.EntityFrameworkCore;
using System;


namespace incicafe.dal
{
    public class CoffeeContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Coffee> Coffees { get; set; }

        public CoffeeContext(DbContextOptions<CoffeeContext> options) : base(options)
        {

        }





        protected override void OnModelCreating(ModelBuilder modelbuilder)

        {
            base.OnModelCreating(modelbuilder);

        }



    }
}
