using nApplication.Services.Repositories;
using Core.Persistence.Repositories;
using nDomain.Entities;
using nPersistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nPersistence.Repositories
{
    public class SomeFeatureEntityRepository : EfRepositoryBase<SomeFeatureEntity, BaseDbContext>, ISomeFeatureEntityRepository
    {
        public SomeFeatureEntityRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
