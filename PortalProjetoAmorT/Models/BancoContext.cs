using System;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PortalProjetoAmor.Models
{
    public class BancoContext : DbContext
    {
        public DbSet<Assistido> Assistidos { get; set; }

        public DbSet<Atendimento> Atendimentos { get; set; }

        public DbSet<Curso> Cursos { get; set; }

        public DbSet<Documento> Documentos { get; set; }

        public DbSet<Doenca> Doencas { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Familia> Familias { get; set; }

        public DbSet<ObjetivoAtendimento> ObjetivosAtendimentos { get; set; }

        public DbSet<Parentesco> Parentescos { get; set; }

        public BancoContext() : base("name=BancoContext")
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PortalProjetoAmor"].ConnectionString;
            Database.Connection.ConnectionString = connectionString;
            
        }
    }
}