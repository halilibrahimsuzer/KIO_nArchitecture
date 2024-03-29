﻿using System;
using Core.CrossCuttingConcerns.Exceptions;
using Core.Persistence.Paging;
using nApplication.Services.Repositories;
using nDomain.Entities;

namespace nApplication.Features.Brands.Rules
{
	public class BrandBusinessRules
	{
        private readonly IBrandRepository _brandRepository;

        public BrandBusinessRules(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task BrandNameCanNotBeDuplicatedWhenInserted(string name)
        {
            IPaginate<Brand> result = await _brandRepository.GetListAsync(b => b.Name == name);
            if (result.Items.Any()) throw new BusinessException("Brand name exists.");
        }
    }
}

