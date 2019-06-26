using System;
using System.Collections.Generic;

namespace ECommerce.Domain.Entities
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int IdStatus { get; set; }
        public virtual StatusPedido Status { get; set; }
        public decimal ValorPedido { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public virtual List<ItemPedido> ItensPedido { get; set; }
    }
}
