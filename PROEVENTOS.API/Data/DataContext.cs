using Microsoft.EntityFrameworkCore;
using PROEVENTOS.API.Models;

namespace PROEVENTOS.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Evento> Eventos { get; set; }
    }
}