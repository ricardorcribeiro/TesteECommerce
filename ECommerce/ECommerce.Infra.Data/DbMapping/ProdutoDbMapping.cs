using ECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Infra.Data.DbMapping
{
    public class ProdutoDbMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        { 
            builder.ToTable("Produtos");
            builder.HasKey(p => p.IdProduto);
        }
    }
}
