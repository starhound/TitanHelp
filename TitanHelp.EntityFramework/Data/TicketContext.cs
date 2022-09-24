using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitanHelp.EntityFramework.Models;

namespace TitanHelp.EntityFramework.Data
{
    public class TicketContext : DbContext
    {
        public string DbPath { get; }
            
        public TicketContext(DbContextOptions<TicketContext> options) 
            : base(options)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "Ticket.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Technician>().ToTable("Technician");
            modelBuilder.Entity<Ticket>().ToTable("Ticket");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Technician> Technicians { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
