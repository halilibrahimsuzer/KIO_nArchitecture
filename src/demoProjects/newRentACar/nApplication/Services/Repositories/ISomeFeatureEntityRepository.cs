using Core.Persistence.Repositories;
using nDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nApplication.Services.Repositories
{
    public interface ISomeFeatureEntityRepository : IAsyncRepository<SomeFeatureEntity>, IRepository<SomeFeatureEntity>
    {
    }
}
