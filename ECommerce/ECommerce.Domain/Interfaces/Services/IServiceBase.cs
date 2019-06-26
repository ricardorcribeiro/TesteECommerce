using System.Collections.Generic;

namespace ECommerce.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        List<TEntity> GetAll();
    }
}
