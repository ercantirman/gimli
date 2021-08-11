using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gimli.Data.Repository.Base
{
    public interface IRepository<TEntity, TPrimaryKey>
    {
        //CRUD : Create Read Update Delete
        
        //Create
        Task Create(TEntity entity);

        //Read
        IQueryable<TEntity> GetAll();

        Task<TEntity> GetById(TPrimaryKey id);

        //Update
        Task Update(TEntity entity);

        //Delete
        Task Delete(TPrimaryKey id);
    }

    public interface IRepository<TEntity> : IRepository<TEntity, int>
    {

    }
}
