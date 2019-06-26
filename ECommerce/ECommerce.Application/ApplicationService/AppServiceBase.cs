using AutoMapper;
using ECommerce.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace ECommerce.Application.ApplicationService
{
    public abstract class AppServiceBase<TEntityDTO, TEntity> : IAppServiceBase<TEntityDTO, TEntity>
        where TEntityDTO : class
        where TEntity : class
    {

        protected readonly IMapper _mapper;
        protected readonly IServiceBase<TEntity> _serviceBase;
        public AppServiceBase(
            IServiceBase<TEntity> serviceBase,
            IMapper mapper
            )
        {
            _serviceBase = serviceBase ?? throw new ArgumentNullException(nameof(serviceBase));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

        }
        
        public TEntityDTO GetById(int id)
            => _mapper.Map<TEntity, TEntityDTO>(_serviceBase.GetById(id));

        public List<TEntityDTO> GetAll()
            => _mapper.Map<List<TEntity>, List<TEntityDTO>>(_serviceBase.GetAll());


    }
}
