using AutoMapper;
using ECommerce.Domain.Entities;
using ECommerce.Infra.CrossCutting.DataTransferObject.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Application.ApplicationService.Pedidos
{
    public class PedidoProfile : Profile
    {
        public static void InitializaMapper()
        {
            Mapper.Initialize(Mapper => {
                Mapper.CreateMap<Pedido, PedidoDTO>().ReverseMap();
            });
        }
    }
}
