using ECommerce.Domain.Entities;
using ECommerce.Domain.Interfaces.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce.Infra.Data.Repositories.Entities
{
    public class HistoricoStatusRepository : RepositoryBase<HistoricoStatus>, IHistoricoStatusRepository
    {
        public HistoricoStatusRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public List<HistoricoStatus> HistoricoByIdPedido(int idPedido)
        {
            var historico = Db.HistoricoStatus.Where(x => x.IdPedido == idPedido).ToList();
            var pedido = Db.Pedidos.Find(idPedido);
            historico.ForEach(x => x.Pedido = pedido);
            return historico;
        }
    }
}
