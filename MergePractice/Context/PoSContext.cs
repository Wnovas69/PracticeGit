﻿using MergePractice.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MergePractice.Context
{
    public class PoSContext : DbContext
    {
        public PoSContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Producto> Producto { get; set; }

        public DbSet<Ventas> Ventas { get; set; }

        public DbSet<Suplidor> Suplidor { get; set; }
    }
}
