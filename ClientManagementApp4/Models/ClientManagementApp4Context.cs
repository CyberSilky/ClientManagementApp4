using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ClientManagementApp4.Models
{
    public class ClientManagementApp4Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ClientManagementApp4Context() : base("name=ClientManagementApp4Context")
        {
        }

        public System.Data.Entity.DbSet<ClientManagementApp4.Models.Client> Clients { get; set; }
    }
}
