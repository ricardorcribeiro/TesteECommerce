using ECommerce.Domain.Entities;
using ECommerce.Infra.Data.DbMapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ECommerce.Infra.Data.Contexts
{
    public class Context : DbContext
    {
        private readonly IConfiguration _configuration;
        public Context(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<HistoricoStatus> HistoricoStatus { get; set; }        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(_configuration["ConnectionString"], options => options.EnableRetryOnFailure());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StatusPedidoDbMapping()); 
            modelBuilder.ApplyConfiguration(new ProdutoDbMapping()); 
            modelBuilder.ApplyConfiguration(new ItemPedidoDbMapping()); 
            modelBuilder.ApplyConfiguration(new PedidoDbMapping()); 
            modelBuilder.ApplyConfiguration(new HistoricoStatusDbMapping()); 
        }
    }
}
