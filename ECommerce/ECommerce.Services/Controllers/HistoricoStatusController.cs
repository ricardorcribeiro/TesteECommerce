using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Application.ApplicationService.HistoricosStatus;
using ECommerce.Infra.CrossCutting.DataTransferObject.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoricoStatusController : ControllerBase
    {
        private IHistoricoStatusAppService _historicoStatusAppService;

        public HistoricoStatusController(IHistoricoStatusAppService historicoStatusAppService)
        {
            _historicoStatusAppService = historicoStatusAppService;
        }

        [HttpGet]
        public List<HistoricoStatusDTO> Get()
        {
            return _historicoStatusAppService.GetAll();
        }
        [HttpGet("HistoricoByIdPedido/{idPedido}")]
        public List<HistoricoStatusDTO> HistoricoByIdPedido(int idPedido)
        {
            return _historicoStatusAppService.HistoricoByIdPedido(idPedido);
        }
    }
}