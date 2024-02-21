using Catolog.API.Entities;
using MongoDB.Driver;

namespace Catolog.API.Data
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }

    }
}
