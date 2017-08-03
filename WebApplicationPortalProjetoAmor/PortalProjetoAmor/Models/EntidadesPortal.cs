using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Configuration;

namespace PortalProjetoAmor.Models
{
    public class EntidadesPortal : DbContext
    {
        public EntidadesPortal() { }

        public EntidadesPortal(string nomeConnectionString)
        {
            if (nomeConnectionString != null)
                Database.Connection.ConnectionString = nomeConnectionString;
            Database.Create();
        }

        public DbSet<Assistido> Assistidos { get; set; }
    }
}