using System.Collections.Generic;
using System.Data;
using System.Linq;
using Retail.Models;
using Retail.MicroORM;


namespace Retail.Repository.Impl
{
    public class ClassifierRepository: AbstractRepository<Classifier>, IClassifierRepository
    {
        private IDbConnection _dbConnection;         
 
        public ClassifierRepository(IDbConnection dbConnection)
        {
            this._dbConnection = dbConnection;          
        }

        protected override IDbConnection GetDbConnection()
        {
            return this._dbConnection;
        }

        public override Classifier Find(int id)
        {
            return
                DbORM.GetEntities<Classifier>(this.GetDbConnection(),
                string.Format(@"select * from Classifier where Id={0}",id)
                ).FirstOrDefault();
        }

         
    }
}
