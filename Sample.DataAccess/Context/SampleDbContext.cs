using Microsoft.EntityFrameworkCore;
using Sample.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Sample.DataAccess.Context
{
    //DbContext görünmesi için Microsoft.EntityFrameworkCore.SqlServer yüklenmeli
    //Migration için Microsoft.EntityFrameworkCore.Tools yüklenmeli

    //!! Bunlar :NET Sürümü ile aynı veya daha düşük olmalı
    internal sealed class SampleDbContext : DbContext, IUnitOfWork
    {
        public SampleDbContext(DbContextOptions options) : base(options)
        {
        }

        public Task<int> SaveShangesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Konfigürasyon dosyalarını proje ile bağlantısını sağlıyor.
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SampleDbContext).Assembly);
        }
    }
}
