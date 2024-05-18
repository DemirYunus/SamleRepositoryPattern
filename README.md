1) Entities katmanı oluşturulur
	1.1) Model oluşturulur
        1.2) Repository oluşturulur

2) DataAccess oluşturulur
    DbContext görünmesi için Microsoft.EntityFrameworkCore.SqlServer yüklenmeli
    Migration için Microsoft.EntityFrameworkCore.Tools yüklenmeli

    !! Bunlar :NET Sürümü ile aynı veya daha düşük olmalı

	? işareti konarak null dönebilir uyarısı kapandı

   public async Task<T?> GetByIDAsync(System.Linq.Expressions.Expression<Func<T, bool>> expression, CancellationToken cancellationToken)
        {
           return await _context.Set<T>().Where(expression).FirstOrDefaultAsync(cancellationToken);
        }