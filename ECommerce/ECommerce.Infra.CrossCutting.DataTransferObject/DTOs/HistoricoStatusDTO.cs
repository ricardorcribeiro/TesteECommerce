using ECommerce.Infra.CrossCutting.DataTransferObject.Enuns;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infra.CrossCutting.DataTransferObject.DTOs
{
    public class HistoricoStatusDTO
    {
        public int IdPedido { get; set; }
        public PedidoDTO Pedido { get; set; }
        public int IdStatus { get; set; }
        public StatusPedidoDTO Status { get; set; }
        public DateTime DataStatus { get; set; }
        public StatusAtraso StatusDoAtraso { get; set; }
    }
}
