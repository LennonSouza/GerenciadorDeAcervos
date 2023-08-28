using GerenciadorDeAcervos.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeAcervos.Data
{
    public class AcervoDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<Colecoes> Colecoes { get; set; }
        public DbSet<Colecao> Colecao { get; set; }
        public DbSet<Objetos> Objetos { get; set; }
        public DbSet<Permissoes> Permissoes { get; set; }

        private readonly string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Fundacao_Cultural_Jacarehy;Trusted_Connection=True;MultipleActiveResultSets=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuarios").HasKey(e => e.UsuarioId);
            modelBuilder.Entity<Usuario>().Property(e => e.Imagem).HasColumnType("varbinary(max)").HasDefaultValue(new byte[0]);

            modelBuilder.Entity<Setor>().HasNoKey();
            modelBuilder.Entity<Colecoes>().HasNoKey();
            modelBuilder.Entity<Colecao>().HasNoKey();
            modelBuilder.Entity<Objetos>().HasNoKey();
            modelBuilder.Entity<Permissoes>().HasNoKey();
        }
    }
}
