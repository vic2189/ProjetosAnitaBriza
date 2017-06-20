using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalProjetoAmor.Configuration
{
    interface IConnectionString
    {
        string Server { get; set; }

        string Database { get; set; }

        string UserId { get; set; }

        string Password { get; set; }

        string ConnectionString { get; set; }

    }
}
