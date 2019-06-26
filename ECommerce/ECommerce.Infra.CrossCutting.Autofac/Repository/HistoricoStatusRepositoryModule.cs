using Autofac;
using ECommerce.Domain.Interfaces.Repositories.Entities;
using ECommerce.Infra.Data.Repositories.Entities;

namespace ECommerce.Infra.CrossCutting.Autofac.Repository
{
    public class HistoricoStatusRepositoryModule : Module
    {
        #region Methods

        protected override void Load(ContainerBuilder builder)
            => builder.RegisterType<HistoricoStatusRepository>().As<IHistoricoStatusRepository>();

        #endregion
    }
}
