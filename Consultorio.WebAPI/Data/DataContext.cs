using Consultorio.WebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace Consultorio.WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}
    
        public DbSet<Agenda> Agendas { get; set; }

    }
}