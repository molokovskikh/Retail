using System.Collections.Generic;
using System.Data;
using System.Linq;
using Retail.MicroORM;


namespace Retail.Repository.Impl
{
    public abstract class AbstractRepository<T>: IRepository<T>
    {

        protected abstract IDbConnection GetDbConnection();

        public virtual T Find(int id)
        {
            return DbORM.GetEntities<T>(this.GetDbConnection()).FirstOrDefault();
        }


        public T Add(T entity)
        {
            return DbORM.PutEntities<T>(new T[] { entity }, this.GetDbConnection()).FirstOrDefault();
        }



        public void Edit(T entity)
        {
            DbORM.PutEntities<T>(new T[] { entity }, this.GetDbConnection()).FirstOrDefault();
        }


        public void Remove(T entity)
        {
            DbORM.PutEntities<T>(new T[] { entity }, this.GetDbConnection()).FirstOrDefault();
        }

        #region IEnumerable
        public IEnumerator<T> GetEnumerator()
        {
            return DbORM.GetEntities<T>(this.GetDbConnection()).AsEnumerable().GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return DbORM.GetEntities<T>(this.GetDbConnection()).AsEnumerable().GetEnumerator();
        }
        #endregion

    }
}
