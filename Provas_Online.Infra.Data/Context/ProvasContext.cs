using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Provas_Online.Dominio.Entidades;
using Microsoft.Extensions.Configuration;

namespace Provas_Online.Infra.Data.Context
{
    public class ProvasContext : DbContext
    {
        public ProvasContext(DbContextOptions<ProvasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Avaliacao> Avaliacoes { get; set; }
        public virtual DbSet<OpcaoQuestao> OpcoesQuestoes { get; set; }
        public virtual DbSet<Professor> Professores { get; set; }
        public virtual DbSet<Publicacao> Publicacoes { get; set; }
        public virtual DbSet<Questao> Questoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Avaliação

            modelBuilder.Entity<Avaliacao>(entity =>
            {
                entity.Property(p => p.Titulo).IsRequired();
                entity.HasKey(p => p.Id);
            });

            modelBuilder.Entity<Avaliacao>()
                .ToTable("Avaliacoes");

            #endregion

            #region Opção Questão

            modelBuilder.Entity<OpcaoQuestao>(entity =>
            {
                entity.HasKey(p => p.Id);
            });

            modelBuilder.Entity<OpcaoQuestao>()
                .ToTable("OpcoesQuestoes");

            #endregion

            #region Professor

            modelBuilder.Entity<Professor>(entity =>
            {
                entity.HasKey(p => p.Id);
            });

            modelBuilder.Entity<Professor>()
                .ToTable("Professores");

            #endregion

            #region Publicacao

            modelBuilder.Entity<Publicacao>(entity =>
            {
                entity.HasKey(p => p.Id);
            });

            modelBuilder.Entity<Publicacao>()
                .ToTable("Publicacoes");

            #endregion

            #region Questão

            modelBuilder.Entity<Questao>(entity =>
            {
                entity.HasKey(p => p.Id);
            });

            modelBuilder.Entity<Questao>()
                .ToTable("Questoes");

            #endregion
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
