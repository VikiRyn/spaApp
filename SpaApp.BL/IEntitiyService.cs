using SpaApp.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpaApp.BL
{
    public interface IEntitiyService<TModel> 
        where TModel : ModelBase
    {
        Task<IEnumerable<TModel>> GetAllAsync();
        Task<TModel> GetByIdAsync(Guid id);
        Task<TModel> AddAsync(TModel model);
        Task<TModel> UpdateAsync(TModel model);
        Task DeleteAsync(Guid id);
    }
}
