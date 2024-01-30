using ElectrodomesticosApi.Model;
using Microsoft.EntityFrameworkCore;

namespace ElectrodomesticosApi.Data
{
    public class ElectrodoDbContext: DbContext
    {
        public ElectrodoDbContext(DbContextOptions<ElectrodoDbContext> options) : base(options)
        { 
        }

        public DbSet<ElectrodomesticosModels> Electrodomesticos { get; set; }
    }
}
