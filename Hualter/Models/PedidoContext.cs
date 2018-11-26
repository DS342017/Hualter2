using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hualter.Models
{
    public class PedidoContext : DbContext
    {
        public PedidoContext() : base("name=PedidoContext")
        {
        }

        public System.Data.Entity.DbSet<Hualter.Models.Pedido> Pedidoes { get; set; }
    }
}
