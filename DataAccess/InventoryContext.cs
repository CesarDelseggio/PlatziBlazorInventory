using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class InventoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<InputOutput> InputsOutputs { get; set; }
        public DbSet<WereHouse> WereHouses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=InventoryDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = Guid.NewGuid().ToString() , Name="Gaseosas" },
                new Category() { Id = Guid.NewGuid().ToString(), Name = "Almacen" },
                new Category() { Id = Guid.NewGuid().ToString(), Name = "Golosinas" },
                new Category() { Id = Guid.NewGuid().ToString(), Name = "Aguas Saborisadas" },
                new Category() { Id = Guid.NewGuid().ToString(), Name = "Jugos" },
                new Category() { Id = Guid.NewGuid().ToString(), Name = "Vinos" }
                );

            modelBuilder.Entity<WereHouse>().HasData(
                    new WereHouse() { Id = Guid.NewGuid().ToString(), Name ="Casa Central", Address = "Cordoba 880"},
                    new WereHouse() { Id = Guid.NewGuid().ToString(), Name = "Centro", Address = "Catamarca 1290" }
                );
        }
    }
}
