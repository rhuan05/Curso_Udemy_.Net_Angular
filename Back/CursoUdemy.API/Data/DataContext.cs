using CursoUdemy.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoUdemy.API.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Evento> Eventos { get; set; }
    }
}