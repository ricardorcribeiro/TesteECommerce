using System.Collections.Generic;

namespace ECommerce.Application.ApplicationService
{
    public interface IAppServiceBase<TEntityDTO, TEntity>
        where TEntityDTO :class
        where TEntity :class
    {
        TEntityDTO GetById(int id);
        List<TEntityDTO> GetAll();
    }
}
