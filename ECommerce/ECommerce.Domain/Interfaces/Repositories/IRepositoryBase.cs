using System.Collections.Generic;

namespace ECommerce.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        List<TEntity> GetAll();
    }
}
