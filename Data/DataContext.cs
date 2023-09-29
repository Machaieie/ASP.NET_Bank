using Microsoft.EntityFrameworkCore;
using Teste.Models.Pessoa;

namespace Teste.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options) { }

        public DbSet<Pessoa> pessoa { get; set; }
    }
}
