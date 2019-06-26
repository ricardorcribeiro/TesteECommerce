using ECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Infra.Data.DbMapping
{
    public class HistoricoStatusDbMapping : IEntityTypeConfiguration<HistoricoStatus>
    {
        public void Configure(EntityTypeBuilder<HistoricoStatus> builder)
        {
            builder.ToTable("HistoricoStatus");
            builder.HasKey(h => new { h.IdPedido, h.IdStatus });

            builder.HasOne(i => i.Pedido)
                .WithOne()
                .HasForeignKey<HistoricoStatus>(i => i.IdPedido);

            builder.HasOne(i => i.Status)
                .WithOne()
                .HasForeignKey<HistoricoStatus>(i => i.IdStatus);

            builder.Ignore(i => i.StatusDoAtraso);
        }
    }
}
