using Retail.Device;
using Retail.Models;
using System.Collections.Generic;

namespace Retail.Repository
{
    public interface ISaleRepository : IRepository<Sale>
    {
        void SaveSale(IEnumerable<ISaleItem> saleItems, Document document);
    }
}
