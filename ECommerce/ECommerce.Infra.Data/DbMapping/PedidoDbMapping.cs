using ECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Infra.Data.DbMapping
{
    public class PedidoDbMapping : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedido");
            builder.HasKey(p => p.IdPedido);

            builder.Property(p => p.IdPedido).HasColumnName("IdPedido");
            builder.Property(p => p.IdStatus).HasColumnName("IdStatus");

            builder.HasOne(p => p.Status)
                .WithOne()
                .HasForeignKey<Pedido>(p => p.IdStatus);
            builder.HasMany(p => p.ItensPedido).WithOne(i => i.Pedido).HasForeignKey(x=>x.IdPedido);
        }
    }
}
