using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    // class : referans tip olabilir demek
    //IEntity: IEntity olabilir yada IEntity implemenete eden bi nesnede olabilir
    //new() :new'lenebilir olabilir IEntity new'lenemez
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //filtrelemeyi sağlar
        List<T> GetAll(Expression<Func<T, bool>> filter = null);// nul filtre vermeyebilirsin o zaman bütün datayı verir
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
