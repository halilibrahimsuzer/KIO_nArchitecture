using System;
using AutoMapper;
using nApplication.Features.Brands.Commands.CreateBrand;
using nApplication.Features.Brands.Dtos;
using nDomain.Entities;

namespace nApplication.Features.Brands.Profiles
{
	public class MappingProfiles: Profile
	{
		public MappingProfiles()
		{
			CreateMap<Brand, CreatedBrandDto>().ReverseMap();
			CreateMap<Brand, CreateBrandCommand>().ReverseMap();
		}
	}
}

