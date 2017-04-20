using System.Collections.Generic;
using System.Data;
using System.Linq;
using Retail.Models;
using Retail.MicroORM;


namespace Retail.Repository.Impl
{
    class ProductRepository: AbstractRepository<Product>, IProductRepository
    {
        private IDbConnection _dbConnection;         
 
        public ProductRepository(IDbConnection dbConnection)
        {
            this._dbConnection = dbConnection;          
        }

        protected override IDbConnection getDbConnection()
        {
            return this._dbConnection;
        }

        public override Product Find(int id)
        {
            return
                DbORM.GetEntities<Product>(this.getDbConnection()).FirstOrDefault();
        }

        public IList<Product> FindByText(string text)
        {
            string query =  string.Format(
@"select p.*,pc.name classifier_name from Product p 
inner join Classifier pc on pc.id = p.classifier_id
where
exists(select id from Classifier c where 
            ( c.Name ilike '%{0}%' or (exists(select * from BarCode b where b.classifier_id=c.id and b.code = '{0}') )
       ) and p.classifier_id = c.id)", 
            text);

            return DbORM.GetEntities<Product>(this.getDbConnection(), query,  (product, column, value) =>
            {
                if ("classifier_name".Equals(column.ToLower()))
                {
                    product.Classifier = product.Classifier ?? new Classifier() { Name = value as string };                    
                }
            });
        }

      
    }
}
