using System.Collections.Generic;
using System.Data;
using System.Linq;
using Retail.Models;
using Retail.MicroORM;


namespace Retail.Repository.Impl
{
    class DocumentRepository: AbstractRepository<Document>, IDocumentRepository
    {
        private IDbConnection _dbConnection;         
 
        public DocumentRepository(IDbConnection dbConnection)
        {
            this._dbConnection = dbConnection;          
        }

        protected override IDbConnection GetDbConnection()
        {
            return this._dbConnection;
        }

    }
}
