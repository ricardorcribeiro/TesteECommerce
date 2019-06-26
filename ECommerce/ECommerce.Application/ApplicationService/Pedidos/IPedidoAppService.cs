using ECommerce.Domain.Entities;
using ECommerce.Infra.CrossCutting.DataTransferObject.DTOs;

namespace ECommerce.Application.ApplicationService.Pedidos
{
    public interface IPedidoAppService : IAppServiceBase<PedidoDTO,Pedido>
    {
    }
}
