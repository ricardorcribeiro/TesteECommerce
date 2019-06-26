namespace ECommerce.Domain.Entities
{
    public class ItemPedido
    {
        public int IdPedido { get; set; }
        public virtual Pedido Pedido { get; set; }
        public int IdProduto { get; set; }
        public virtual Produto Produto { get; set; }
        public decimal PrecoVenda { get; set; }
        public int IdStatus { get; set; }
        public virtual StatusPedido Status { get; set; }
    }
}
