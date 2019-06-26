using AutoMapper;
using ECommerce.Domain.Entities;
using ECommerce.Domain.Interfaces.Services;
using ECommerce.Domain.Interfaces.Services.Entities;
using ECommerce.Infra.CrossCutting.DataTransferObject.DTOs;
using System.Collections.Generic;

namespace ECommerce.Application.ApplicationService.HistoricosStatus
{
    public class HistoricoStatusAppService : AppServiceBase<HistoricoStatusDTO, HistoricoStatus>, IHistoricoStatusAppService
    {
        public HistoricoStatusAppService(IHistoricoStatusService serviceBase, IMapper mapper) : base(serviceBase, mapper)
        {
        }

        public List<HistoricoStatusDTO> HistoricoByIdPedido(int idPedido)
            => _mapper.Map<List<HistoricoStatusDTO>>((_serviceBase as IHistoricoStatusService).HistoricoByIdPedido(idPedido));
    }
}
