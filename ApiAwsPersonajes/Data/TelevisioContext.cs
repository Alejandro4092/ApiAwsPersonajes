using ApiAwsPersonajes.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiAwsPersonajes.Data
{
    public class TelevisioContext:DbContext
    {
        public TelevisioContext(DbContextOptions<TelevisioContext> options) : base(options)
        {
        }
        public DbSet<Personaje> Personajes { get; set; }
    }
}
