using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
// using ru_student_dotnet6.Models;

namespace ru_student_dotnet6.Contexts
{
    public partial class ru_data_centerContext : DbContext
    {
        public ru_data_centerContext()
        {
        }

        public ru_data_centerContext(DbContextOptions<ru_data_centerContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=ru_data_center;Username=postgres;Password=admin1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
