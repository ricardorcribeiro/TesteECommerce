using Autofac;
using ECommerce.Domain.Interfaces.Services.Entities;
using ECommerce.Domain.Services.Entities;

namespace ECommerce.Infra.CrossCutting.Autofac.Service
{
    public class HistoricoStatusServiceModule : Module
    {
        #region Methods

        protected override void Load(ContainerBuilder builder)
            => builder.RegisterType<HistoricoStatusService>().As<IHistoricoStatusService>();

        #endregion
    }
}
