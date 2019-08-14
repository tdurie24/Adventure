using System;
using Adventure.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Adventure.Data
{
    public class AdventureDbContext : DbContext
    {
        public AdventureDbContext(DbContextOptions<AdventureDbContext> options):base(options)
        {

        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Coordinator> Coordinators { get; set; }
        public DbSet<GeoCoordinate> GeoCoordinates { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<HolidayType> HolidayTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventImage>().HasKey(s => new { s.EventId, s.ImageId });
        }
    }
}
