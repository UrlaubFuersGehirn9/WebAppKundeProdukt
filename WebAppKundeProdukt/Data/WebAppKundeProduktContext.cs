using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppKundeProdukt.Models;

namespace WebAppKundeProdukt.Data
{
    public class WebAppKundeProduktContext : DbContext
    {
        public WebAppKundeProduktContext (DbContextOptions<WebAppKundeProduktContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppKundeProdukt.Models.Kunde> Kunde { get; set; } = default!;
        public DbSet<WebAppKundeProdukt.Models.Produkt> Produkt { get; set; } = default!;
        public DbSet<WebAppKundeProdukt.Models.Warenkorbposition> Warenkorbposition { get; set; } = default!;
   }
}
