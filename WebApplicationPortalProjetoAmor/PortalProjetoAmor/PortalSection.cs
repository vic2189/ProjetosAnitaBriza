using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using System.Configuration;
using System.Web.Services.Description;

namespace PortalProjetoAmor
{
    //Colocar no main(), na primeira chamada para carregar
    //PortalSection processConfigurationSection = ConfigurationManager.GetSection("portal") as PortalSection;
    public class PortalSection: ConfigurationSection
    {
        // Create a element.
        [ConfigurationProperty("conexaoBanco")]
        public ConexaoElemento ConexaoBanco
        {
            get
            {
                return (ConexaoElemento)this["conexaoBanco"];
            }
            private set
            { this["conexaoBanco"] = value; }
        }
    }

    public class ConexaoElemento : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = true)]
        public String Name
        {
            get
            {
                return (String)this["name"];
            }
            private set
            {
                this["name"] = value;
            }
        }

        [ConfigurationProperty("connectionString", IsRequired = true)]
        //[StringValidator(InvalidCharacters = "~!@#$%^&*;", MinLength = 35)]
        public String ConnectionString
        {
            get
            {
                return (String)this["connectionString"];
            }
            private set
            {
                this["connectionString"] = value;
            }
        }
    }
}
