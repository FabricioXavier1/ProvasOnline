using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Provas_Online.Dominio.Entidades;

namespace Provas_Online.Infra.Data.ContextConfig
{
    public class ConfigContext : DbContext
    {
        public ConfigContext(DbContextOptions<ConfigContext> options) 
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
            modelBuilder.Entity<Avaliacao>(entity =>
            {
                entity.Property(p => p.Id).ValueGeneratedNever();
            });
        }
    }
}
