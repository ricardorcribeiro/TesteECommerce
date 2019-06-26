using ECommerce.Domain.Entities;
using System.Collections.Generic;

namespace ECommerce.Domain.Interfaces.Repositories.Entities
{
    public interface IHistoricoStatusRepository : IRepositoryBase<HistoricoStatus>
    {
        List<HistoricoStatus> HistoricoByIdPedido(int idPedido);
    }
}
