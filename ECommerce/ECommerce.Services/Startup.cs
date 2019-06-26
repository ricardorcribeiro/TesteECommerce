using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using ECommerce.Application.ApplicationService.Pedidos;
using ECommerce.Domain.Entities;
using ECommerce.Infra.CrossCutting.Autofac.Service;
using ECommerce.Infra.CrossCutting.DataTransferObject.DTOs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace ECommerce.Services
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(options => {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            #region AutoMapper
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new PedidoProfile());
            });

            IMapper mapper = new MapperConfiguration(cfg => {
                cfg.CreateMap<Pedido, PedidoDTO>();
                cfg.CreateMap<ItemPedido, ItemPedidoDTO>();
                cfg.CreateMap<StatusPedido, StatusPedidoDTO>();
                cfg.CreateMap<HistoricoStatus, HistoricoStatusDTO>();
                cfg.CreateMap<Produto, ProdutoDTO>();
            }).CreateMapper(); ;
            services.AddSingleton(mapper);
            #endregion

            #region Autofac

            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterAssemblyModules(
                Assembly.GetAssembly(typeof(PedidoServiceModule)),
                Assembly.GetExecutingAssembly());

            containerBuilder.Populate(services);

            var container = containerBuilder.Build();

            return new AutofacServiceProvider(container);

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseCors("MyPolicy");
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
