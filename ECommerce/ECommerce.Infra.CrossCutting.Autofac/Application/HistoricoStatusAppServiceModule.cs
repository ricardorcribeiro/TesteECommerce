using Autofac;
using ECommerce.Application.ApplicationService.HistoricosStatus;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infra.CrossCutting.Autofac.Application
{
    public class HistoricoStatusAppServiceModule : Module
    {
        #region Methods

        protected override void Load(ContainerBuilder builder)
            => builder.RegisterType<HistoricoStatusAppService>().As<IHistoricoStatusAppService>();

    #endregion
}
}
