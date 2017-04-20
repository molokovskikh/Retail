using System.Data;
using Autofac;
using MySql.Data.MySqlClient;
using Retail.Repository.Impl;


namespace Retail.Repository
{
    /// <summary>
    /// Класс регистрации в IoC контейнере
    /// </summary>
    public class AutofacModule : Module
    {
        /// <summary>
        /// Регистрация репозиториев в IoC контейнере
        /// </summary>
        /// <param name="builder"></param>        
        protected override void Load(ContainerBuilder builder)
        {                        
            MySqlConnection mySqlCOnnection = new MySqlConnection(builder.Properties["connectionString"] as string);
            builder.RegisterInstance(mySqlCOnnection).As<IDbConnection>();
            builder.RegisterType<ClassifierRepository>().As<IClassifierRepository>();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<SaleRepository>().As<ISaleRepository>();
            builder.RegisterType<StoreRepository>().As<IStoreRepository>();
            builder.RegisterType<BarCodeRepository>().As<IBarCodeRepository>();
            builder.RegisterType<DefecturaRepository>().As<IDefecturaRepository>();
            builder.RegisterType<DocumentRepository>().As<IDocumentRepository>();
        }
    }
}
