using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using oneToManyDemo.Models;

namespace oneToManyDemo.Context
{
    public class OneToOneDemoContext: DbContext
    {
    public DbSet<Person> Persons { get; set; }
    public DbSet<Address> Addresses { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost; user=sa; password=12345678; Database=DemoOneToOnePerson; Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasOne(p=>p.PersonAddress)
                .WithOne(a => a.Person)
                .HasForeignKey<Address>(a => a.PersonId);
        }

    }


}