using ECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Infra.Data.DbMapping
{
    public class ItemPedidoDbMapping : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.ToTable("ItemPedido");
            builder.HasKey(i => new { i.IdPedido, i.IdProduto});

            builder.Property(i => i.IdPedido).HasColumnName("IdPedido");
            builder.Property(i => i.IdProduto).HasColumnName("IdProduto");

            builder.HasOne(i => i.Status)
                .WithOne()
                .HasForeignKey<ItemPedido>(i => i.IdStatus);
        }
    }
}
