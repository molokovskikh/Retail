using System.Collections.Generic;
using System.Data;
using System.Linq;
using Retail.Models;
using Retail.MicroORM;


namespace Retail.Repository.Impl
{
   class BarCodeRepository: AbstractRepository<BarCode>, IBarCodeRepository
    {
        private IDbConnection _dbConnection;         
 
        public BarCodeRepository(IDbConnection dbConnection)
        {
            this._dbConnection = dbConnection;          
        }

        protected override IDbConnection GetDbConnection()
        {
            return this._dbConnection;
        }

        public override BarCode Find(int id)
        {
            return
                DbORM.GetEntities<BarCode>(_dbConnection).FirstOrDefault();
        }
         
    }
}
