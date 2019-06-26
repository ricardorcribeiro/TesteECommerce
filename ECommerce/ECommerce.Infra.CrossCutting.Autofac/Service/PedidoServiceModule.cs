using Autofac;
using ECommerce.Domain.Interfaces.Services.Entities;
using ECommerce.Domain.Services.Entities;

namespace ECommerce.Infra.CrossCutting.Autofac.Service
{
    public class PedidoServiceModule : Module
    {
        #region Methods

        protected override void Load(ContainerBuilder builder)
            => builder.RegisterType<PedidoService>().As<IPedidoService>();

        #endregion
    }
}
