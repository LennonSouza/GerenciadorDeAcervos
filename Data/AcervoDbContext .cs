using GerenciadorDeAcervos.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeAcervos.Data
{
    public class AcervoDbContext : DbContext
    {
        public DbSet<Permissao> Permissoes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Instituicao> Instituicao { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<Colecao> Colecoes { get; set; }
        public DbSet<Objeto> Objetos { get; set; }

        private readonly string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Fundacao_Cultural_Jacarehy;Trusted_Connection=True;MultipleActiveResultSets=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurações das entidades
            modelBuilder.Entity<Permissao>().HasKey(k => k.PermissaoId);
            modelBuilder.Entity<Instituicao>().HasKey(k => k.InstituicaoId);
            modelBuilder.Entity<Setor>().HasKey(k => k.SetorId);
            modelBuilder.Entity<Colecao>().HasKey(k => k.ColecaoId);
            modelBuilder.Entity<Objeto>().HasKey(k => k.ObjetoId);

            // Configuração do tipo de dados para a propriedade Imagem
            modelBuilder.Entity<Usuario>().Property(e => e.Imagem).HasColumnType("varbinary(max)").HasDefaultValue(Array.Empty<byte>());

            // Configuração do relacionamento entre Usuario e Permissao 
            modelBuilder.Entity<Usuario>().HasOne(u => u.Permissao).WithMany().HasForeignKey(u => u.PermissaoId);

            // Configuração do relacionamento entre Objeto e Colecao
            modelBuilder.Entity<Objeto>().HasOne(o => o.Colecao).WithMany(c => c.Objetos).HasForeignKey(o => o.ColecaoId);

            // Configuração do relacionamento entre Colecao e Setor
            modelBuilder.Entity<Colecao>().HasOne(c => c.Setor).WithMany(s => s.Colecoes).HasForeignKey(c => c.SetorId);

            // Configuração do relacionamento entre Setor e Instituicao
            modelBuilder.Entity<Setor>().HasOne(s => s.Insituicao).WithMany(g => g.Setores).HasForeignKey(s => s.InstituicaoId); 
        }
    }
}
