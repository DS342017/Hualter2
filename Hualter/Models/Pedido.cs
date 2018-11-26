using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hualter.Models
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }
        public String NomeMedicamento { get; set; }
        public String QtdeMendicamento { get; set; }
        public String CodCliente { get; set; }
        public String DataEntrega { get; set; }
    }
}