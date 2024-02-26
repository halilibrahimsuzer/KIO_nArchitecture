using System;
using Core.Persistence.Repositories;
using nDomain.Entities;

namespace nApplication.Services.Repositories
{
	public interface IBrandRepository : IAsyncRepository<Brand>, IRepository<Brand>
    {
	}
}

