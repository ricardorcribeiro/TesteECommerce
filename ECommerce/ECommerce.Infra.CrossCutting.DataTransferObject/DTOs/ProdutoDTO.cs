namespace ECommerce.Infra.CrossCutting.DataTransferObject.DTOs
{
    public class ProdutoDTO
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal PrecoVenda { get; set; }
    }
}