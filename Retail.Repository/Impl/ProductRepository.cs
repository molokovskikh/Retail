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

        protected override IDbConnection GetDbConnection()
        {
            return this._dbConnection;
        }

        public override Product Find(int id)
        {
            return
                DbORM.GetEntities<Product>(this.GetDbConnection()).FirstOrDefault();
        }

        public IList<Product> SearchByText(string text)
        {
            string query =  string.Format(
@"select p.id Id,p.price Price,pc.name classifier_name from Product p 
inner join Classifier pc on pc.id = p.classifier_id
where
exists(select ps.product_id from productonstore ps where ps.product_id = p.id and ps.amount > 1) and 
exists(select id from Classifier c where 
            ( c.Name like '%{0}%' or (exists(select * from BarCode b where b.classifier_id=c.id and b.code = '{0}') )
       ) and p.classifier_id = c.id)", 
            text);

            return DbORM.GetEntities<Product>(this.GetDbConnection(), query,  (product, column, value) =>
            {
                if ("classifier_name".Equals(column.ToLower()))
                {
                    product.Classifier = product.Classifier ?? new Classifier() { Name = value as string };                    
                }
            },
              (typeDst,src) => 
                  typeDst.Equals(typeof(decimal)) && (src is long||src is int) 
                  ? ((long)src) / 10000m 
                  : src
            );
        }

      
    }
}
