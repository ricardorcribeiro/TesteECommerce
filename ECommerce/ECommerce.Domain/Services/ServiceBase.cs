using ECommerce.Domain.Interfaces.Repositories;
using ECommerce.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace ECommerce.Domain.Services
{
    public abstract class ServiceBase<TEntity> : IServiceBase<TEntity>
    where TEntity : class
    {
        protected readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        
        public TEntity GetById(int id) 
            =>_repository.GetById(id);

        public List<TEntity> GetAll()
            => _repository.GetAll();

    }
}
