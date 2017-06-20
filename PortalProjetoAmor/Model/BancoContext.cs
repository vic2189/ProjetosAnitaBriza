using System;
using System.Data.Common;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PortalProjetoAmor.Model.Listas;

namespace PortalProjetoAmor.Models
{
    public class BancoContext : DbContext
    {

        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        { }

        public DbSet<Assistido> Assistidos { get; set; }

        public DbSet<Atendimento> Atendimentos { get; set; }

        public DbSet<Curso> Cursos { get; set; }

        public DbSet<Documento> Documentos { get; set; }

        public DbSet<Doenca> Doencas { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Familia> Familias { get; set; }

        public DbSet<ObjetivoAtendimento> ObjetivosAtendimentos { get; set; }

        public DbSet<Parentesco> Parentescos { get; set; }

        public DbSet<Bairro> Bairros { get; set; }

        public DbSet<Cidade> Cidades { get; set; }

        public DbSet<Estado> Estados { get; set; }

        public DbSet<EstadoCivil> EstadoCivis { get; set; }

        public DbSet<Pais> Paises { get; set; }

        public DbSet<TipoDocumento> TipoDocumentos { get; set; }

        public DbSet<TipoDoenca> TipoDoencas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assistido>().ToTable("TB_Assistido");
            modelBuilder.Entity<Atendimento>().ToTable("TB_Atendimento");
            modelBuilder.Entity<Curso>().ToTable("TB_Curso");
            modelBuilder.Entity<Documento>().ToTable("TB_Documento");
            modelBuilder.Entity<Doenca>().ToTable("TB_Doenca");
            modelBuilder.Entity<Endereco>().ToTable("TB_Endereco");
            modelBuilder.Entity<Familia>().ToTable("TB_Familia");
            modelBuilder.Entity<ObjetivoAtendimento>().ToTable("TB_ObjetivoAtendimento");
            modelBuilder.Entity<Parentesco>().ToTable("TB_Parentesco");
            modelBuilder.Entity<Bairro>().ToTable("TB_Bairro");
            modelBuilder.Entity<Cidade>().ToTable("TB_Cidade");
            modelBuilder.Entity<Estado>().ToTable("TB_Estado");
            modelBuilder.Entity<Pais>().ToTable("TB_Pais");
            modelBuilder.Entity<TipoDocumento>().ToTable("TB_TipoDocumento");
            modelBuilder.Entity<TipoDoenca>().ToTable("TB_TipoDoenca");
            modelBuilder.Entity<EstadoCivil>().ToTable("TB_EstadoCivil");
        }
    }
}