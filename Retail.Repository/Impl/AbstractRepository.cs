using System.Collections.Generic;
using System.Data;
using System.Linq;
using Retail.MicroORM;


namespace Retail.Repository.Impl
{
    public abstract class AbstractRepository<T>: IRepository<T>
    {

        protected abstract IDbConnection getDbConnection();

        public virtual T Find(int id)
        {
            return DbORM.GetEntities<T>(this.getDbConnection()).FirstOrDefault();
        }


        public T Add(T entity)
        {
            return DbORM.PutEntities<T>(new T[] { entity }, this.getDbConnection()).FirstOrDefault();
        }



        public void Edit(T entity)
        {
            DbORM.PutEntities<T>(new T[] { entity }, this.getDbConnection()).FirstOrDefault();
        }


        public void Remove(T entity)
        {
            DbORM.PutEntities<T>(new T[] { entity }, this.getDbConnection()).FirstOrDefault();
        }

        #region IEnumerable
        public IEnumerator<T> GetEnumerator()
        {
            return DbORM.GetEntities<T>(this.getDbConnection()).AsEnumerable().GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return DbORM.GetEntities<T>(this.getDbConnection()).AsEnumerable().GetEnumerator();
        }
        #endregion

    }
}
