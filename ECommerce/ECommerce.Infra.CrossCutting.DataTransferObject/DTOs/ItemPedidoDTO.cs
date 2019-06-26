using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infra.CrossCutting.DataTransferObject.DTOs
{
    public class ItemPedidoDTO
    {
        public int IdPedido { get; set; }
        public PedidoDTO Pedido { get; set; }
        public int IdProduto { get; set; }
        public ProdutoDTO Produto { get; set; }
        public decimal PrecoVenda { get; set; }
        public int IdStatus { get; set; }
        public StatusPedidoDTO Status { get; set; }
    }
}
