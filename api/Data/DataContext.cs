using api.Model;
using Microsoft.EntityFrameworkCore;
namespace api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Pessoa> pessoa { get; set; }
        public DbSet<Animais> animais { get; set; }
        public DbSet<PetShop> petshop { get; set; }
    }

}
