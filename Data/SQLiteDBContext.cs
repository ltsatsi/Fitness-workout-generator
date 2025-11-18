using FitnessWG.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessWG.Data
{
    public class SQLiteDBContext : DbContext
    {
        public SQLiteDBContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Workout> Workouts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Exercise>().ToTable("Exercise");
            modelBuilder.Entity<Workout>().ToTable("Workout");
        }
    }
}
