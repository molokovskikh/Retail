using System.Collections.Generic;
using System.Data;
using System.Linq;
using Retail.Models;
using Retail.MicroORM;


namespace Retail.Repository.Impl
{
    class DefecturaRepository: AbstractRepository<Defectura>, IDefecturaRepository
    {
        private IDbConnection _dbConnection;         
 
        public DefecturaRepository(IDbConnection dbConnection)
        {
            this._dbConnection = dbConnection;          
        }

        protected override IDbConnection GetDbConnection()
        {
            return this._dbConnection;
        }
   
        public override Defectura Find(int id)
        {
            return
                DbORM.GetEntities<Defectura>(_dbConnection).FirstOrDefault();
        }
         
    }
}
