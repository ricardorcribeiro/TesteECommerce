using ECommerce.Domain.Entities;
using System.Collections.Generic;

namespace ECommerce.Domain.Interfaces.Services.Entities
{
    public interface IHistoricoStatusService : IServiceBase<HistoricoStatus>
    {
        List<HistoricoStatus> HistoricoByIdPedido(int idPedido);
    }
}
