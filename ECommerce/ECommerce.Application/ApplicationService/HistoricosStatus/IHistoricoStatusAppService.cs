using ECommerce.Domain.Entities;
using ECommerce.Infra.CrossCutting.DataTransferObject.DTOs;
using System.Collections.Generic;

namespace ECommerce.Application.ApplicationService.HistoricosStatus
{
    public interface IHistoricoStatusAppService : IAppServiceBase<HistoricoStatusDTO, HistoricoStatus>
    {
        List<HistoricoStatusDTO> HistoricoByIdPedido(int idPedido);
    }
}
