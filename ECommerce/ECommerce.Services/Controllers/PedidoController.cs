using ECommerce.Application.ApplicationService.Pedidos;
using ECommerce.Infra.CrossCutting.DataTransferObject.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ECommerce.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private IPedidoAppService _pedidoAppService;

        public PedidoController(IPedidoAppService pedidoAppService)
        {
            _pedidoAppService = pedidoAppService;
        }

        [HttpGet]
        public List<PedidoDTO> Get()
            => _pedidoAppService.GetAll();

        [HttpGet("{id}")]
        public PedidoDTO Get(int id)
            => _pedidoAppService.GetById(id);
    }
}