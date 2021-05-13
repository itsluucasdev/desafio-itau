using Microsoft.EntityFrameworkCore;
using desafio_itau.Models;  

namespace desafio_itau.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }
        public DbSet<Cotacao> Cotacoes { get; set; }
        public DbSet<Taxa> Taxas { get; set; }
    }
}