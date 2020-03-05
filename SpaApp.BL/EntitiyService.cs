using ApsApp.DAL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SpaApp.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SpaApp.BL
{
    public class EntitiyService<TEntity, TModel> : IEntitiyService<TModel>
        where TEntity: EntityBase
        where TModel : ModelBase
    {

        public EntitiyService(IEntityRepository<TEntity> repository)
        {
            Repository = repository;
        }

        protected IEntityRepository<TEntity> Repository { get; }
        protected IMapper Mapper { get; }

        public async Task<IEnumerable<TModel>> GetAllAsync()
        {
            var entities = await Repository.GetAll().ToListAsync();
            var models = Mapper.Map<IEnumerable<TModel>>(entities);

            return models;
        }

        public async Task<TModel> GetByIdAsync(Guid id)
        {
            var entity = await Repository.GetByIdAsync(id);
            var model = Mapper.Map<TModel>(entity);

            return model;
        }

        public async Task<TModel> AddAsync(TModel model)
        {
            var entity = Mapper.Map<TEntity>(model);

            await Repository.AddAsync(entity);
            await Repository.SaveChanges();

            return await GetByIdAsync(model.Id);
        }

        public async Task<TModel> UpdateAsync(TModel model)
        {
            var originalEntity = await Repository.GetByIdAsync(model.Id);
            Mapper.Map(model, originalEntity);

            Repository.Update(originalEntity);
            await Repository.SaveChanges();

            var updatedEntity = await Repository.GetByIdAsync(model.Id);
            var updatedModel = Mapper.Map<TModel>(updatedEntity);

            return updatedModel;
        }

        public async Task DeleteAsync(Guid id)
        {
            var model = await GetByIdAsync(id);
            var entity = Mapper.Map<TEntity>(model);

            Repository.Delete(entity);
            await Repository.SaveChanges();
        }
    }
}
