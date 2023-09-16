using GerenciadorDeAcervos.Data.Models;
using Microsoft.EntityFrameworkCore;
using static GerenciadorDeAcervos.Funcoes.GlobalConfiguration;

namespace GerenciadorDeAcervos.Data
{
    public class AcervoDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Insituicao> Insituicao { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<Colecao> Colecoes { get; set; }
        public DbSet<Objeto> Objetos { get; set; }
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

            modelBuilder.Entity<Permissoes>().HasKey(k => k.PermissaoId);

            modelBuilder.Entity<Objeto>().HasOne(o => o.Colecao).WithMany(c => c.Objetos).HasForeignKey(o => o.ColecaoId);
            modelBuilder.Entity<Colecao>().HasOne(c => c.Setor).WithMany(s => s.Colecoes).HasForeignKey(c => c.SetorId);
            modelBuilder.Entity<Setor>().HasOne(s => s.Insituicao).WithMany(g => g.Setores).HasForeignKey(s => s.InsituicaoId);
        }
    }
}
