using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AgendaTelefonica.Models
{
    public class AgendaContext : DbContext 
    {
        public AgendaContext() : base("DbLoja")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Consultor> Consultores { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
    }
}