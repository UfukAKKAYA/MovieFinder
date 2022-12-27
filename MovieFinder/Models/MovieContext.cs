using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieFinder.Models
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Director> Directors { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<MovieCategory> MovieCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=MovieFinderDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieCategory>()
            .HasKey(hk => new { hk.MovieId, hk.CategoryId });

            modelBuilder.Entity<MovieCategory>()
            .HasOne(hk => hk.Movie)
            .WithMany(h => h.Categories)
            .HasForeignKey(hk => hk.MovieId);

            modelBuilder.Entity<MovieCategory>()
            .HasOne(hk => hk.Category)
            .WithMany(k => k.MovieCategories)
            .HasForeignKey(hk => hk.CategoryId);
        }
    }
}
