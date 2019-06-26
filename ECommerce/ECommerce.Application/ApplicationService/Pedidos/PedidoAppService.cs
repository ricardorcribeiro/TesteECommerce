using AutoMapper;
using ECommerce.Domain.Entities;
using ECommerce.Domain.Interfaces.Services.Entities;
using ECommerce.Infra.CrossCutting.DataTransferObject.DTOs;

namespace ECommerce.Application.ApplicationService.Pedidos
{
    public class PedidoAppService : AppServiceBase<PedidoDTO, Pedido>, IPedidoAppService
    {
        public PedidoAppService(IPedidoService serviceBase, IMapper mapper) : base(serviceBase, mapper)
        {
        }
    }
}
