namespace ControleDeSeriesFilmes.MODEL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EFFilmesSeries : DbContext
    {
        public EFFilmesSeries()
            : base("name=EFFilmesSeries")
        {
        }

        public virtual DbSet<filme> filmes { get; set; }
        public virtual DbSet<series> series { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<filme>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<filme>()
                .Property(e => e.Classificacao)
                .IsUnicode(false);

            modelBuilder.Entity<filme>()
                .Property(e => e.Diretor)
                .IsUnicode(false);

            modelBuilder.Entity<filme>()
                .Property(e => e.Estudio)
                .IsUnicode(false);

            modelBuilder.Entity<series>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<series>()
                .Property(e => e.Classificacao)
                .IsUnicode(false);

            modelBuilder.Entity<series>()
                .Property(e => e.Diretor)
                .IsUnicode(false);

            modelBuilder.Entity<series>()
                .Property(e => e.Estudio)
                .IsUnicode(false);
        }
    }
}
