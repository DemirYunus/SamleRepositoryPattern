using Sample.DataAccess.Context;
using Sample.Entities.Model;
using Sample.Entities.Repositories;

namespace Sample.DataAccess.Repositories
{
    internal sealed class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(SampleDbContext context) : base(context)
        {
        }
    }
}
