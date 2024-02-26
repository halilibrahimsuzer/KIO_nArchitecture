using System;
using Core.Persistence.Repositories;
using nApplication.Services.Repositories;
using nDomain.Entities;
using nPersistence.Contexts;

namespace nPersistence.Repositories
{
    public class BrandRepository : EfRepositoryBase<Brand, BaseDbContext>, IBrandRepository
    {
        public BrandRepository(BaseDbContext context) : base(context)
        {
        }
    }
}

