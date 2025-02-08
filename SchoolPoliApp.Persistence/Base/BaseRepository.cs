

using Microsoft.EntityFrameworkCore;
using SchoolPoliApp.Domain.Base;
using SchoolPoliApp.Domain.Repository;
using SchoolPoliApp.Persistence.Context;
using System.Linq.Expressions;

namespace SchoolPoliApp.Persistence.Base
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly SchoolContext _context;
        private DbSet<TEntity> Entity { get; set; }
        public BaseRepository(SchoolContext context)
        {
            _context = context;
            Entity = _context.Set<TEntity>();
        }
        public virtual async Task<OperationResult> SaveEntityAsync(TEntity entity)
        {
            OperationResult result = new OperationResult();

            try
            {
                Entity.Add(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error guardando los datos.";
            }
            return result;
           
        }
        public virtual async Task<OperationResult> UpdateEntityAsync(TEntity entity)
        {
            OperationResult result = new OperationResult();
            try
            {
                Entity.Update(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error guardando los datos.";
            }
            return result;
        }
        public virtual async Task<OperationResult> GetAllAsync(Expression<Func<TEntity, bool>> filter)
        {
            OperationResult result = new OperationResult();

            try
            {
                var datos = Entity.Where(filter).ToListAsync();
               
                result.Data = datos;
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error obteniendo los datos.";
            }
              
            return result;
         
        }

        public virtual async Task<TEntity> GetEntityByIdAsync(int id)
        {
            return await Entity.FindAsync(id);
        }
        public virtual async Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> filter)
        {

            return await Entity.AnyAsync(filter);
        }
        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            return await Entity.ToListAsync();
        }

    }
}
