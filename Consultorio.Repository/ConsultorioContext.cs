
using Consultorio.Domain;
using Microsoft.EntityFrameworkCore;

namespace Consultorio.Repository
{
    public class ConsultorioContext : DbContext
    {
        public ConsultorioContext(DbContextOptions<ConsultorioContext> options) : base (options){}
    
        public DbSet<Atendimento> Atendimentos { get; set; }

        public DbSet<Acompanhamentos> Acompanhamentos { get; set; }

        public DbSet<Hospital> Hospitais { get; set; }

        public DbSet<Paciente> Pacientes { get; set; }

        public DbSet<Responsavel> Responsaveis { get; set; }

        public DbSet<Sintomas> Sintomas { get; set; }

        public DbSet<Status> Status { get; set; }

        public DbSet<ResponsavelAtendimento> ResponsavelAtendimentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ResponsavelAtendimento>()
                .HasKey(RA => new{ RA.ResponsavelId, RA.AtendimentoId });
        }


    }
}