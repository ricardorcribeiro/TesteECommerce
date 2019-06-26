using ECommerce.Domain.Entities;
using ECommerce.Domain.Interfaces.Repositories;
using ECommerce.Domain.Interfaces.Repositories.Entities;
using ECommerce.Domain.Interfaces.Services.Entities;

namespace ECommerce.Domain.Services.Entities
{
    public class PedidoService : ServiceBase<Pedido>, IPedidoService
    {
        public PedidoService(IPedidoRepository repository) : base(repository) {}
    }
}
