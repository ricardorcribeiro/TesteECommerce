using Autofac;
using ECommerce.Application.ApplicationService.Pedidos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infra.CrossCutting.Autofac.Application
{
    public class PedidoAppServiceModule : Module
    {
        #region Methods

        protected override void Load(ContainerBuilder builder)
            => builder.RegisterType<PedidoAppService>().As<IPedidoAppService>();

        #endregion
    }
}
