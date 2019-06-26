using ECommerce.Domain.Entities;
using ECommerce.Domain.Interfaces.Repositories;
using ECommerce.Domain.Interfaces.Repositories.Entities;
using ECommerce.Domain.Interfaces.Services.Entities;
using System.Collections.Generic;

namespace ECommerce.Domain.Services.Entities
{
    public class HistoricoStatusService : ServiceBase<HistoricoStatus>, IHistoricoStatusService
    {
        public HistoricoStatusService(IHistoricoStatusRepository repository) : base(repository)
        {
        }

        public List<HistoricoStatus> HistoricoByIdPedido(int idPedido)
            => (_repository as IHistoricoStatusRepository).HistoricoByIdPedido(idPedido);
    }
}
