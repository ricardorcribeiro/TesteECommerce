using ECommerce.Domain.Entities;
using ECommerce.Domain.Interfaces.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq;

namespace ECommerce.Infra.Data.Repositories.Entities
{
    public class PedidoRepository : RepositoryBase<Pedido>, IPedidoRepository
    {
        public PedidoRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
