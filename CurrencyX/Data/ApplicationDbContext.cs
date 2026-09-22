using CurrencyX.Models;
using Microsoft.EntityFrameworkCore;

namespace CurrencyConverter.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Currency> Currencies { get; set; }

        public DbSet<ConversionHistory> ConversionHistories { get; set; }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Currency>().HasData(
                new Currency
                {
                    Id = 1,
                    Code = "USD",
                    Name = "US Dollar",
                    Symbol = "$"
                },
                new Currency
                {
                    Id = 2,
                    Code = "INR",
                    Name = "Indian Rupee",
                    Symbol = "₹"
                },
                new Currency
                {
                    Id = 3,
                    Code = "EUR",
                    Name = "Euro",
                    Symbol = "€"
                },
                new Currency
                {
                    Id = 4,
                    Code = "GBP",
                    Name = "British Pound",
                    Symbol = "£"
                },
                new Currency
                {
                    Id = 5,
                    Code = "JPY",
                    Name = "Japanese Yen",
                    Symbol = "¥"
                }
            );
        }
    }
}