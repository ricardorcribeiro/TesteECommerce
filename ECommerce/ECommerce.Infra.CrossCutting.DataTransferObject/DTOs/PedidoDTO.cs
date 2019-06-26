using System;
using System.Collections.Generic;

namespace ECommerce.Infra.CrossCutting.DataTransferObject.DTOs
{
    public class PedidoDTO
    {
        public int IdPedido { get; set; }
        public int IdStatus { get; set; }
        public StatusPedidoDTO Status { get; set; }
        public decimal ValorPedido { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public List<ItemPedidoDTO> ItensPedido { get; set; }
    }
}