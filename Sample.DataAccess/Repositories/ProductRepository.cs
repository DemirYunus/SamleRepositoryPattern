using Sample.DataAccess.Context;
using Sample.DataAccess.Repositories;
using Sample.Entities.Model;
using Sample.Entities.Repositories;

internal sealed class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(SampleDbContext context) : base(context)
    {
    }
}
