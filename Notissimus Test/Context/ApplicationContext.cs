using Microsoft.EntityFrameworkCore;
using Notissimus_Test.Models;

namespace Notissimus_Test.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<SavedOfferModel> Offer { get; set; }
        public DbSet<yml_catalogShopOfferCategoryId> CategoryIDs { get; set; }
        public DbSet<yml_catalogShopOfferHall> OfferHalls { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SavedOfferModel>()
                .Property(k => k.ID)
                .ValueGeneratedNever();
        }
    }
}
